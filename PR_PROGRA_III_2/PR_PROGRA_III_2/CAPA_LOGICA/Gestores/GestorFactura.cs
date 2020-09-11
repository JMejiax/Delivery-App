using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Gestores
{
    /// <summary>
    ///  Clase cuya función es gestionar la clase Factura
    /// </summary>
    public class GestorFactura
    {
        /// <summary>
        /// Propiedad que almacena la Factura
        /// </summary>
        Factura _Factura;

        /// <summary>
        /// Constructor que inicializa la propiedad _Factura
        /// </summary>
        public GestorFactura()
        {
            _Factura = new Factura();
        }

        /// <summary>
        /// Asigna el cliente a la factura
        /// </summary>
        /// <param name="cliente"></param>
        public void AsignarCliente(Cliente cliente)
        {
            _Factura._Cliente = cliente;
        }

        /// <summary>
        /// Asigna el negocio a la factura
        /// </summary>
        /// <param name="negocio"></param>
        public void AsignarNegocio(Negocio negocio)
        {
            _Factura._Negocio = negocio;
        }

        /// <summary>
        /// Asigna el pedido a la factura
        /// </summary>
        /// <param name="pedido"></param>
        public void AsignarPedido(FacadePedido pedido)
        {
            _Factura._Pedido = pedido;
        }

        /// <summary>
        /// Asigna el estado de la factura a la factura
        /// </summary>
        /// <param name="Estado"></param>
        public void AsignarEstadoFactura(string Estado)
        {
            _Factura.Estado_Factura = Estado;
        }

        /// <summary>
        /// Asigna el estado del pedido a la factura
        /// </summary>
        /// <param name="Estado"></param>
        public void AsignarEstadoPedido(string Estado)
        {
            _Factura.Estado_Pedido = Estado;
        }

        /// <summary>
        /// Asigna el estado de calificación a la factura
        /// </summary>
        /// <param name="Estado"></param>
        public void AsignarEstadoCalificacion(string Estado)
        {
            _Factura.Estado_Calificacion = Estado;
        }

        /// <summary>
        /// Asigna la fecha en que se hizo la factura
        /// </summary>
        /// <param name="fecha"></param>
        public void AsignarFecha(DateTime fecha)
        {
            _Factura.Fecha = fecha;
        }

        /// <summary>
        /// Llama la función que calcula el costo del express del pedido
        /// </summary>
        /// <returns>Retorna el costo del express del pedido</returns>
        public double CostoExpress()
        {
            return _Factura.CostoExpress();
        }

        /// <summary>
        /// Llama la función que calcula el costo total de la factura
        /// </summary>
        /// <returns>Retorna el costo total de la factura</returns>
        public double CostoTotal()
        {
            return _Factura.CostoTotal();
        }

        /// <summary>
        /// Llama la función que calcula el costo total de la factura en dolares
        /// </summary>
        /// <returns>Retorna el costo total de la factura en dolares</returns>
        public double CostoTotalDolares()
        {
            return _Factura.CostoTotalDolares();
        }

        /// <summary>
        /// Llama la función que genera el archivo XML en la clase factura
        /// </summary>
        /// <returns>Retorna el XML de la factura</returns>
        public string ObtenerXML()
        {
            return _Factura.ObtenerXML();
        }

        /// <summary>
        /// Llama la función que crea el PDF en la clase Factura
        /// </summary>
        public void GenerarPDF()
        {
            _Factura.GenerarPDF();
        }

        /// <summary>
        /// Obtiene la propiedad _Factura
        /// </summary>
        /// <returns>Retorna la Factura</returns>
        public Factura ObtenerFactura()
        {
            return _Factura;
        }

    }
}
