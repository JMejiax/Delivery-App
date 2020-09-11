using CAPA_ENTIDADES.Clases;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CAPA_ENTIDADES.Utilitarios;
using CAPA_ENTIDADES.Factory;

namespace CAPA_DATOS
{
    public class ArticuloDB
    {
        #region INSERTAR
        public static void InsertarProducto(Producto prod, int NegocioID)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarProducto";
                comando.Parameters.AddWithValue("@Usuario_id", NegocioID);
                comando.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
                comando.Parameters.AddWithValue("@Fotografia", Util.ConvertirImagenAByte(prod.Fotografia));
                comando.Parameters.AddWithValue("@Nombre", prod.Nombre);
                comando.Parameters.AddWithValue("@Precio", prod.Precio);

                db.ExecuteNonQuery(comando);
            }
        }
        
        public static void InsertarCuponDescuento(CupoDescuento cupon, int NegocioID)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarCuponDescuento";
                comando.Parameters.AddWithValue("@Usuario_id", NegocioID);
                comando.Parameters.AddWithValue("@Descripcion", cupon.Descripcion);
                comando.Parameters.AddWithValue("@Fotografia", Util.ConvertirImagenAByte(cupon.Fotografia));
                comando.Parameters.AddWithValue("@Nombre", cupon.Nombre);
                comando.Parameters.AddWithValue("@QR", cupon.Codigo_QR);
                comando.Parameters.AddWithValue("@Descuento", cupon.PorcentajeDescuento);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", cupon.FechaVencimiento);

                db.ExecuteNonQuery(comando);
            }
        }
        
        public static void InsertarCuponProd(CuponProductoGratis cupon, int NegocioID)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarCuponProdGratis";
                comando.Parameters.AddWithValue("@Usuario_id", NegocioID);
                comando.Parameters.AddWithValue("@Descripcion", cupon.Descripcion);
                comando.Parameters.AddWithValue("@Fotografia", Util.ConvertirImagenAByte(cupon.Fotografia));
                comando.Parameters.AddWithValue("@Nombre", cupon.Nombre);
                comando.Parameters.AddWithValue("@QR", cupon.Codigo_QR);
                comando.Parameters.AddWithValue("@Articulo_id", cupon.IDProducto);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", cupon.FechaVencimiento);

                db.ExecuteNonQuery(comando);
            }
        }

        #endregion INSERTAR

        #region ACTUALIZAR
        public static void ActualizarProducto(Producto prod)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarProducto";
                comando.Parameters.AddWithValue("@id", prod.Id);
                comando.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
                comando.Parameters.AddWithValue("@Fotografia", Util.ConvertirImagenAByte(prod.Fotografia));
                comando.Parameters.AddWithValue("@Nombre", prod.Nombre);
                comando.Parameters.AddWithValue("@Precio", prod.Precio);

                db.ExecuteNonQuery(comando);
            }
        }
        public static void ActualizarCuponDescuento(CupoDescuento cupon)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCuponDescuento";
                comando.Parameters.AddWithValue("@id", cupon.Id);
                comando.Parameters.AddWithValue("@Descripcion", cupon.Descripcion);
                comando.Parameters.AddWithValue("@Fotografia", Util.ConvertirImagenAByte(cupon.Fotografia));
                comando.Parameters.AddWithValue("@Nombre", cupon.Nombre);
                comando.Parameters.AddWithValue("@QR", cupon.Codigo_QR);
                comando.Parameters.AddWithValue("@Descuento", cupon.PorcentajeDescuento);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", cupon.FechaVencimiento);

                db.ExecuteNonQuery(comando);
            }
        }

        public static void ActualizarCuponProd(CuponProductoGratis cupon)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCuponProdGratis";
                comando.Parameters.AddWithValue("@id", cupon.Id);
                comando.Parameters.AddWithValue("@Descripcion", cupon.Descripcion);
                comando.Parameters.AddWithValue("@Fotografia", Util.ConvertirImagenAByte(cupon.Fotografia));
                comando.Parameters.AddWithValue("@Nombre", cupon.Nombre);
                comando.Parameters.AddWithValue("@QR", cupon.Codigo_QR);
                comando.Parameters.AddWithValue("@Articulo_id", cupon.IDProducto);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", cupon.FechaVencimiento);

                db.ExecuteNonQuery(comando);
            }
        }

        #endregion ACTUALIZAR
        public static void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarArticulo";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public static List<Articulo> SeleccionarTodas(int codigo, long PIN)
        {
            List<Articulo> lista = new List<Articulo>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCategorias";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Articulo cat = new Articulo();
                    cat.Id = (int)dr["Id"];
                    cat.Nombre = dr["Nombre"].ToString();
                    lista.Add(cat);
                }
            }

            return lista;
        }

        /// <summary>
        /// Se encarga de seleccionar un Articulo de acuerdo al ID ingresado
        /// </summary>
        ///<param name="id">EL ID unico del Articulo a consultar</param>
        ///<returns>Objeto de tipo Articulo</returns>
        public static Articulo SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarArticuloPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Articulo art = null;
                    //Se crea el objeto transporte de acuerdo a su tipo
                    FactoryArticulo fa = new FactoryArticulo();
                    art = fa.CrearArticulo((SeleccionarTipoArticuloPorID((int)dr["TIPO_ARTICULO_ID"])));

                    // Se agregan las propiedades especificas de cada 
                    if(art is Producto)
                        (art as Producto).Precio = (double)dr["PRECIO"];

                    if (art is CupoDescuento)
                    {
                        (art as CupoDescuento).PorcentajeDescuento = ((int)dr["CUPON_DESCUENTO_PORCENTAJE"]) / 100.0d;
                        (art as CupoDescuento).FechaVencimiento = (DateTime)dr["FECHA_VENCIMIENTO"];
                        (art as CupoDescuento).Codigo_QR = dr["CODIGO_QR"].ToString();
                    }

                    if (art is CuponProductoGratis)
                    {
                        (art as CuponProductoGratis).IDProducto = (int)dr["PRODUCTO_GRATIS_ID"];
                        (art as CuponProductoGratis).FechaVencimiento = (DateTime)dr["FECHA_VENCIMIENTO"];
                        (art as CuponProductoGratis).Codigo_QR = dr["CODIGO_QR"].ToString();
                    }
                            
                    
                    art.Id = (int)dr["ARTICULO_ID"];
                    art.UsuarioId = (int)dr["USUARIO_ID"];
                    art.Descripcion = dr["DESCRIPCION"].ToString();

                    art.Fotografia = Util.ConvertirImagen((byte[])dr["FOTOGRAFIA"]);

                    art.Nombre = dr["NOMBRE"].ToString();
                    art.Activo = dr["Activo"].ToString().ToLower().Equals("activo");
                    return art;
                }
            }

            return null;
        }

        /// <summary>
        /// Se encarga de seleccionar los articulos de un Negocio
        /// </summary>
        ///<param name="id">EL ID unico del Negocio</param>
        ///<returns>Una lista de objetos de tipo Articulo</returns>
        public static List<Articulo> ObtenerArticulosPorIDUsuario(int id)
        {
            List<Articulo> lista = new List<Articulo>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarProductoPorNegocioID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Articulo art = SeleccionarPorId((int)dr["ARTICULO_ID"]);
                    lista.Add(art);
                }
            }

            return lista;
        }

        /// <summary>
        /// Seleccionar el cupo que contenga el codigo QR brindado
        /// </summary>
        ///<param name="QR">EL codigo QR unico del articulo</param>
        ///<returns>Devuelve un objeto de tipo cupon</returns>
        public static Cupon SeleccionarCuponPorQR(string QR)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCupoPorQR";
                comando.Parameters.AddWithValue("@QR", QR);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cupon _Cupon = null;
                    TipoArticulo tp = SeleccionarTipoArticuloPorID((int)dr["TIPO_ARTICULO_ID"]);

                    // Se agregan las propiedades especificas de cada 
                    if (tp == TipoArticulo.CuponDescuento)
                    {
                        _Cupon = (CupoDescuento)SeleccionarPorId((int)dr["ARTICULO_ID"]);
                        (_Cupon as CupoDescuento).PorcentajeDescuento = ((int)dr["CUPON_DESCUENTO_PORCENTAJE"]) / 100.0d;
                    }

                    if (tp == TipoArticulo.CuponProductoGratis)
                    {
                        _Cupon = (CuponProductoGratis)SeleccionarPorId((int)dr["ARTICULO_ID"]);
                        //(_Cupon as CuponProductoGratis).IDProducto = (int)dr["PRODUCTO_GRATIS_ID"];
                    }
                    return _Cupon;
                }
            }

            return null;
        }

        /// <summary>
        /// Se encarga de obtener el tipo de articulo que se está consultando
        /// </summary>
        ///<param name="id">EL ID unico del articulo</param>
        ///<returns>Un string con el nombre del tipo de articulo</returns>
        public static TipoArticulo SeleccionarTipoArticuloPorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoArticuloPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string ta = dr["TIPO_ARTICULO"].ToString().ToLower();

                    if (ta.Equals("producto")) return TipoArticulo.Producto;
                    if (ta.Equals("cupon_desc")) return TipoArticulo.CuponDescuento;
                }
            }
            return TipoArticulo.CuponProductoGratis;
        }
    }
}
