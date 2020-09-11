using CAPA_ENTIDADES.Facade;
using CAPA_ENTIDADES.Interfaces;
using CAPA_ENTIDADES.Utilitarios;
using iText.Kernel.Colors;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que contiene la definición del objeto factura
    /// </summary>
    public class Factura
    {
        // Propiedades para usar en el dgv pedidos de negocios
        /// <summary>
        /// Propiedad cuya funcion es servir de columna para los data grid views usados en la parte grafica
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propiedad cuya funcion es servir de columna para los data grid views usados en la parte grafica
        /// </summary>
        public string Telefono { get; set; }
        // Propiedades para usar en el dgv pedidos de negocios

        /// <summary>
        /// Propiedad que almacena el ID de la factura
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propiedad que almacena objeto Negocio de la factura
        /// </summary>
        public Negocio _Negocio { get; set; }

        /// <summary>
        /// Propiedad que almacena el objetp Cliente de la factura
        /// </summary>
        public Cliente _Cliente { get; set; }

        /// <summary>
        /// Propiedad que almacena el objeto Repartidor de la factura
        /// </summary>
        public Repartidor _Repartidor { get; set; }

        /// <summary>
        /// Propiedad que almacena el objeto Pedido de la factura
        /// </summary>
        public FacadePedido _Pedido { get; set; }

        /// <summary>
        /// Propiedad que almacena el estado actual del pedido
        /// </summary>
        public string Estado_Pedido { get; set; }

        /// <summary>
        /// Propiedad que almacena el estado actual de la factura
        /// </summary>
        public string Estado_Factura { get; set; }

        /// <summary>
        /// Propiedad que almacena un string que dice si el pedido ya ha sido calificado por el cliente
        /// </summary>
        public string Estado_Calificacion { get; set; }

        /// <summary>
        /// Propiedad que almacena la fecha en la que fue generado el pedido
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Calcula el monto del express del pedido
        /// </summary>
        /// <returns>Retorna el monto a pagar por el cliente por el express del pedido</returns>
        public double CostoExpress()
        {
            double lat1 = Convert.ToDouble(_Cliente._Direccion.latitud.Replace('.', ','));
            double lng1 = Convert.ToDouble(_Cliente._Direccion.longitud.Replace('.', ','));
            double lat2 = Convert.ToDouble(_Negocio._Direccion.latitud.Replace('.', ','));
            double lng2 = Convert.ToDouble(_Negocio._Direccion.longitud.Replace('.', ','));

            double distancia = Express.calcularDistancia2(lng1, lat1, lng2, lat2);
            return distancia * 100.0;
        }

        /// <summary>
        /// Calcula el costo total de la factura
        /// </summary>
        /// <returns>Retorna el costo total de la factura</returns>
        public double CostoTotal()
        {
            return _Pedido.CostoSinCupones() - _Pedido.DescuentoCupon() + _Pedido.ImpuestoVentas() + CostoExpress();
        }

        /// <summary>
        /// Calcula el costo total de la factura en dólares
        /// </summary>
        /// <returns>Retorna el costo total de la factura en dólares</returns>
        public double CostoTotalDolares()
        {
            return Moneda.ConversionDolares(CostoTotal());
        }

        /// <summary>
        /// Se encarga de crear el string del documento XML de la factura
        /// </summary>
        /// <returns>Retorna un string que contiene el documento XML de la factura</returns>
        public string ObtenerXML()
        {
            XmlDocument documento = new XmlDocument();
            documento.LoadXml("<raiz></raiz>");

            // Versión del documento
            XmlElement versiondoc = documento.CreateElement("versiondoc");
            versiondoc.InnerText = "DOC-V1.0 (?)";
            documento.DocumentElement.AppendChild(versiondoc);

            // Información del negocio
            XmlElement negocio = documento.CreateElement("negocio");

            // > Identificación del negocio
            XmlElement negocioID = documento.CreateElement("idnegocio");
            negocioID.InnerText = _Negocio.Cedula;
            negocio.AppendChild(negocioID);

            // > Dirección del Negocio
            XmlElement direccion = documento.CreateElement("direccion");
            direccion.InnerText = _Negocio._Direccion.Descripcion;
            negocio.AppendChild(direccion);

            documento.DocumentElement.AppendChild(negocio);

            // Tipo de documento
            XmlElement tipodocumento = documento.CreateElement("tipodocumento");
            tipodocumento.InnerText = "Factura Electrónica";
            documento.DocumentElement.AppendChild(tipodocumento);

            // Numeración consecutiva
            XmlElement numerodocumento = documento.CreateElement("numerodocumento");
            numerodocumento.InnerText = "000-000-000-001 (?)";
            documento.DocumentElement.AppendChild(numerodocumento);

            // Clave númerica
            XmlElement clavenumerica = documento.CreateElement("clavenumerica");
            clavenumerica.InnerText = "clave numerica (?)";
            documento.DocumentElement.AppendChild(clavenumerica);

            // Fecha y hora de emisión del documento
            XmlElement fechaemision = documento.CreateElement("fechaemision");
            fechaemision.InnerText = Fecha.ToString();
            documento.DocumentElement.AppendChild(fechaemision);

            //La hora podria ir separada

            // Condiciones de la venta
            XmlElement condicionventa = documento.CreateElement("condicionventa");
            condicionventa.InnerText = "Contado";
            documento.DocumentElement.AppendChild(condicionventa);

            // Medio de pago
            XmlElement mediopago = documento.CreateElement("mediopago");
            mediopago.InnerText = "Tarjeta";
            documento.DocumentElement.AppendChild(mediopago);

            // Normativa vigente
            XmlElement normativa = documento.CreateElement("normativa");
            normativa.InnerText = "Autorizada mediante resolución Nº DGT-R-48-2016 del 7 de octubre de 2016";
            documento.DocumentElement.AppendChild(normativa);

            // Detalle factura
            XmlElement productos = documento.CreateElement("productos");
            foreach (Producto prod in _Pedido.ObtenerPedido())
            {
                // Información de cada producto
                XmlElement producto = documento.CreateElement("producto");
                // Nombre del producto
                XmlElement nombreproducto = documento.CreateElement("nombreproducto");
                nombreproducto.InnerText = prod.Nombre;
                producto.AppendChild(nombreproducto);

                // Cantida de productos 
                XmlElement unidades = documento.CreateElement("unidades");
                unidades.InnerText = prod.Cantidad.ToString();
                producto.AppendChild(unidades);

                // Precio por producto
                XmlElement preciounidad = documento.CreateElement("preciounidad");
                preciounidad.InnerText = prod.Precio.ToString();
                producto.AppendChild(preciounidad);

                // Precio total por cantidad de productos
                XmlElement preciototal = documento.CreateElement("preciototal");
                preciototal.InnerText = prod.Costo().ToString();
                producto.AppendChild(preciototal);

                productos.AppendChild(producto);
            }
            documento.DocumentElement.AppendChild(productos);

            // SubTotal de la factura
            XmlElement subtotal = documento.CreateElement("subtotal");
            subtotal.InnerText = _Pedido.CostoSinCupones().ToString();
            documento.DocumentElement.AppendChild(subtotal);

            // Descuento por cupón
            if (_Pedido._Cupon != null)
            {
                XmlElement descuento = documento.CreateElement("descuento");
                descuento.SetAttribute("monto", _Pedido.DescuentoCupon().ToString());
                descuento.InnerText = "Descuento por cupón";
                documento.DocumentElement.AppendChild(descuento);
            }

            // Impuesto por la compra
            XmlElement impuesto = documento.CreateElement("impuesto");
            impuesto.InnerText = _Pedido.ImpuestoVentas().ToString();
            documento.DocumentElement.AppendChild(impuesto);

            // Monto del express
            XmlElement montoexpress = documento.CreateElement("montoexpress");
            montoexpress.InnerText = CostoExpress().ToString();
            documento.DocumentElement.AppendChild(montoexpress);

            // Total de la compra
            XmlElement montototal = documento.CreateElement("montototal");
            montototal.InnerText = CostoTotal().ToString();
            documento.DocumentElement.AppendChild(montototal);

            // Total de la compra en dolares
            XmlElement montototaldolares = documento.CreateElement("montototaldolares");
            montototaldolares.InnerText = CostoTotalDolares().ToString();
            documento.DocumentElement.AppendChild(montototaldolares);

            return documento.OuterXml;
        }

        /// <summary>
        /// Genera el pdf de la factura
        /// </summary>
        public void GenerarPDF()
        {
            if(File.Exists(@"FacturaElectronica.pdf"))
            File.Delete(@"FacturaElectronica.pdf");

            using (System.IO.FileStream filestream = new System.IO.FileStream(@"FacturaElectronica.pdf", FileMode.Create))
            {
                Document document = new Document(PageSize.LETTER, 10, 10, 10, 10);

                string fuente = "c:/windows/fonts/arialbd.ttf";
                BaseFont bf = BaseFont.CreateFont(fuente, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                PdfWriter writer = PdfWriter.GetInstance(document, filestream);
                document.Open();

                #region ENCABEZADO
                // Encabezado de la pagina
                PdfPTable encabezadoPag = new PdfPTable(3);
                encabezadoPag.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                encabezadoPag.DefaultCell.Border = 0;

                encabezadoPag.AddCell(new Paragraph());

                PdfPCell cell = new PdfPCell();
                Paragraph titulo = new Paragraph("Delivery S.A");
                titulo.Font = FontFactory.GetFont(FontFactory.HELVETICA, 20f, BaseColor.BLACK);
                cell = new PdfPCell(titulo);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Border = 0;
                encabezadoPag.AddCell(cell);

                encabezadoPag.AddCell(new Paragraph());

                #endregion ENCABEZADO

                document.Add(encabezadoPag);

                document.Add(new Paragraph("\n\n"));

                // Acá iria la imagen

                //

                #region INFORMACION NEGOCIO
                // Encerrar en una tabla
                PdfPTable infoNegocio = new PdfPTable(1);

                PdfPCell info = new PdfPCell();
                Paragraph columnName = new Paragraph("Información del negocio");
                columnName.Font = FontFactory.GetFont(FontFactory.HELVETICA, 16f, BaseColor.BLACK);
                info = new PdfPCell(columnName);
                info.HorizontalAlignment = Element.ALIGN_LEFT;
                info.BackgroundColor = BaseColor.LIGHT_GRAY;
                infoNegocio.AddCell(info);

                // Crear el encabezado
                string encabezado = _Negocio.Nombre +
                    "\nCédula Jurídica: " + _Negocio.Cedula +
                    "\nDirección: " + _Negocio._Direccion.Descripcion +
                    "\nCorreo electrónico: " + _Negocio.Correo +
                    "\nTélefono: " + _Negocio.NumeroTelefono + "\n\n";
                // Añadir el encabezado al pdf
                Paragraph paragraph = new Paragraph();
                paragraph.SpacingBefore = 10;
                paragraph.SpacingAfter = 10;
                paragraph.Alignment = Element.ALIGN_LEFT;
                paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                paragraph.Add(encabezado);
                info = new PdfPCell(paragraph);
                info.HorizontalAlignment = Element.ALIGN_LEFT;
                infoNegocio.AddCell(info);

                #endregion INFORMACION NEGOCIO

                document.Add(infoNegocio);


                #region INFORMACION CLIENTE
                // Encerrar en una tabla
                PdfPTable infoCliente = new PdfPTable(1);
                infoCliente.Complete = true;
                columnName = new Paragraph("Información del cliente");
                columnName.Font = FontFactory.GetFont(FontFactory.HELVETICA, 16f, BaseColor.BLACK);
                info = new PdfPCell(columnName);
                info.HorizontalAlignment = Element.ALIGN_LEFT;
                info.BackgroundColor = BaseColor.LIGHT_GRAY;
                infoCliente.AddCell(info);

                // Información del cliente
                string cliente = "Identificación: " + _Cliente.Cedula +
                    "\nNombre: " + _Cliente.Nombre + " " + _Cliente.Apellidos +
                    "\nTélefono: " + _Cliente.NumeroTelefono +
                    "\nCorreo electrónico: " + _Cliente.Correo +
                    "\nDirección: " + _Cliente._Direccion.Descripcion + "\n\n";
                // Añadir la información del clienteal pdf
                Paragraph paragraph1 = new Paragraph();
                paragraph1.SpacingBefore = 10;
                paragraph1.SpacingAfter = 10;
                paragraph1.Alignment = Element.ALIGN_LEFT;
                paragraph1.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                paragraph1.Add(cliente);
                info = new PdfPCell(paragraph1);
                info.HorizontalAlignment = Element.ALIGN_LEFT;
                infoCliente.AddCell(info);

                #endregion INFORMACION CLIENTE

                document.Add(infoCliente);

                #region INFORMACION EXTRA
                PdfPTable tbExtraInfo = new PdfPTable(1);

                columnName = new Paragraph("Fecha de venta: " + Fecha.ToString() +
                                           "\nNúmero de factura N°00001\n\n");
                columnName.SpacingBefore = 10;
                columnName.SpacingAfter = 10;
                columnName.Alignment = Element.ALIGN_LEFT;
                columnName.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                info = new PdfPCell(columnName);
                info.HorizontalAlignment = Element.ALIGN_LEFT;
                tbExtraInfo.AddCell(info);

                if (_Pedido._Cupon is CuponProductoGratis)
                {
                    columnName = new Paragraph("*Se ha usado el cupón: " + _Pedido._Cupon.Nombre + " para reclamar un producto gratis\n\n");
                    columnName.Font = FontFactory.GetFont(FontFactory.HELVETICA, 16f, BaseColor.BLACK);
                    info = new PdfPCell(columnName);
                    info.HorizontalAlignment = Element.ALIGN_LEFT;
                    tbExtraInfo.AddCell(info);
                }
                columnName = new Paragraph("Detalle de la factura");
                columnName.Font = FontFactory.GetFont(FontFactory.HELVETICA, 16f, BaseColor.BLACK);
                info = new PdfPCell(columnName);
                info.HorizontalAlignment = Element.ALIGN_CENTER;
                info.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbExtraInfo.AddCell(info);

                #endregion INFORMACION EXTRA

                document.Add(tbExtraInfo);

                #region TABLA PRODUCTOS
                // Tabla con los productos
                PdfPTable tbProductos = new PdfPTable(6);

                // Llenar clumnas tabla
                PdfPCell column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Código"));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbProductos.AddCell(column);

                column = new PdfPCell(new Paragraph("Nombre"));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbProductos.AddCell(column);

                column = new PdfPCell(new Paragraph("Descripción"));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbProductos.AddCell(column);

                column = new PdfPCell(new Paragraph("Cantidad"));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbProductos.AddCell(column);

                column = new PdfPCell(new Paragraph("Precio Unidad"));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbProductos.AddCell(column);

                column = new PdfPCell(new Paragraph("Precio Total"));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbProductos.AddCell(column);

                foreach (var prod in _Pedido.ObtenerPedido())
                {
                    PdfPCell _Cell = new PdfPCell();

                    // Llenar tabla
                    _Cell = new PdfPCell(new Paragraph(prod.Id.ToString()));
                    _Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tbProductos.AddCell(_Cell);

                    _Cell = new PdfPCell(new Paragraph(prod.Nombre));
                    _Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tbProductos.AddCell(_Cell);

                    _Cell = new PdfPCell(new Paragraph(prod.Descripcion));
                    _Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tbProductos.AddCell(_Cell);

                    _Cell = new PdfPCell(new Paragraph(prod.Cantidad.ToString()));
                    _Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tbProductos.AddCell(_Cell);

                    _Cell = new PdfPCell(new Paragraph(prod.Precio.ToString()));
                    _Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tbProductos.AddCell(_Cell);

                    _Cell = new PdfPCell(new Paragraph(prod.Costo().ToString()));
                    _Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tbProductos.AddCell(_Cell);

                }

                #endregion TABLA PRODUCTOS

                document.Add(tbProductos);

                #region COSTOS DE FACTURA

                PdfPTable tbCostos = new PdfPTable(2);
                // Llenar clumnas tabla

                // Subtotal
                column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Subtotal:"));
                column.HorizontalAlignment = Element.ALIGN_RIGHT;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbCostos.AddCell(column);

                column = new PdfPCell(new Paragraph("₡" + _Pedido.CostoSinCupones(), new Font(bf)));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                tbCostos.AddCell(column);

                // Descuento
                column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Descuento (Cupón):"));
                column.HorizontalAlignment = Element.ALIGN_RIGHT;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbCostos.AddCell(column);

                column = new PdfPCell(new Paragraph("₡" + _Pedido.DescuentoCupon(), new Font(bf)));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                tbCostos.AddCell(column);

                // Impuestos
                column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Impuestos:"));
                column.HorizontalAlignment = Element.ALIGN_RIGHT;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbCostos.AddCell(column);

                column = new PdfPCell(new Paragraph("₡" + _Pedido.ImpuestoVentas(), new Font(bf)));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                tbCostos.AddCell(column);

                // Express
                column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Otros (Express):"));
                column.HorizontalAlignment = Element.ALIGN_RIGHT;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbCostos.AddCell(column);

                column = new PdfPCell(new Paragraph("₡" + CostoExpress(), new Font(bf)));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                tbCostos.AddCell(column);

                // Total Colones
                column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Total (Colones):"));
                column.HorizontalAlignment = Element.ALIGN_RIGHT;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbCostos.AddCell(column);

                column = new PdfPCell(new Paragraph("₡" + CostoTotal(), new Font(bf)));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                tbCostos.AddCell(column);

                // Total Dolares
                column = new PdfPCell();
                column = new PdfPCell(new Paragraph("Total (Doláres):"));
                column.HorizontalAlignment = Element.ALIGN_RIGHT;
                column.BackgroundColor = BaseColor.LIGHT_GRAY;
                tbCostos.AddCell(column);

                column = new PdfPCell(new Paragraph("$" + CostoTotalDolares(), new Font(bf)));
                column.HorizontalAlignment = Element.ALIGN_CENTER;
                tbCostos.AddCell(column);

                #endregion COSTOS DE FACTURA

                document.Add(tbCostos);

                #region EXTRA

                document.Add(new Paragraph("\n\n"));
                var text1 = new Paragraph("Código XML: \n" + Util.ComputeSha256Hash(ObtenerXML()));
                document.Add(text1);

                document.Add(new Paragraph("\n"));
                var text2 = new Paragraph("Autorizada mediante resolución Nº DGT-R-48-2016 del 7 de octubre de 2016");
                document.Add(text2);

                #endregion EXTRA
                
                document.Close();
                filestream.Dispose();

            }
        }
    }
}
