using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class FacturaDB
    {
        /// <summary>
        /// Guarda una factura nueva en la base de datos
        /// </summary>
        ///<param name="_Factura">Objeto Factura</param>
        public static void Insertar(Factura _Factura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarFactura";
                comando.Parameters.AddWithValue("@FECHA", _Factura.Fecha);
                comando.Parameters.AddWithValue("@SUBTOTAL", _Factura._Pedido.CostoSinCupones());
                comando.Parameters.AddWithValue("@MONTO_EXPRESS", _Factura.CostoExpress());
                comando.Parameters.AddWithValue("@IMPUESTO", _Factura._Pedido.ImpuestoVentas());
                comando.Parameters.AddWithValue("@DESCUENTO", _Factura._Pedido.DescuentoCupon());
                comando.Parameters.AddWithValue("@MONTO_TOTAL", _Factura.CostoTotal());
                comando.Parameters.AddWithValue("@MONTO_TOTAL_DOLARES", _Factura.CostoTotalDolares());
                comando.Parameters.AddWithValue("@ESTADO_PEDIDO", _Factura.Estado_Pedido);
                comando.Parameters.AddWithValue("@ESTADO_FACTURA", _Factura.Estado_Factura);
                comando.Parameters.AddWithValue("@ESTADO_CALIFICACION", _Factura.Estado_Calificacion);
                comando.Parameters.AddWithValue("@CODIGO_CIFRADO", Util.ComputeSha256Hash(_Factura.ObtenerXML()));


                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Crea una nueva relación entre el cliente y la factura
        /// </summary>
        /// <param name="_Factura">Objeto Factura</param>
        /// <param name="puntaje"></param>
        /// <param name="comentario"></param>
        public static void RelacionarCliente(Factura _Factura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarFacturaCliente";
                comando.Parameters.AddWithValue("@USUARIO_ID", _Factura._Cliente.Id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Crea una nueva relación entre el negocio o repartidor y la factura
        /// </summary>
        /// <param name="_Factura">Objeto Factura</param>
        /// <param name="puntaje"></param>
        /// <param name="comentario"></param>
        public static void RelacionarNegocio(Factura _Factura, double puntaje, string comentario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarFacturaNegocio";
                comando.Parameters.AddWithValue("@USUARIO_ID", _Factura._Negocio.Id);
                comando.Parameters.AddWithValue("@PUNTAJE", puntaje);
                comando.Parameters.AddWithValue("@COMENTARIO", comentario);


                db.ExecuteNonQuery(comando);
            }
        }

        public static void ActualizarRelacionNegocio(Factura _Factura, double puntaje, string comentario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarFacturaNegocio";
                comando.Parameters.AddWithValue("@idNegocio", _Factura._Negocio.Id);
                comando.Parameters.AddWithValue("@idFactura", _Factura.Id);
                comando.Parameters.AddWithValue("@puntaje", puntaje);
                comando.Parameters.AddWithValue("@comentario", comentario);


                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Crea una nueva relación entre el negocio o repartidor y la factura
        /// </summary>
        /// <param name="_Factura">Objeto Factura</param>
        /// <param name="puntaje"></param>
        /// <param name="comentario"></param>
        public static void RelacionarRepartidor(Factura _Factura, double puntaje, string comentario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarFacturaNR";
                comando.Parameters.AddWithValue("@USUARIO_ID", _Factura._Repartidor.Id);
                comando.Parameters.AddWithValue("@FACTURA_ID", _Factura.Id);
                comando.Parameters.AddWithValue("@PUNTAJE", puntaje);
                comando.Parameters.AddWithValue("@COMENTARIO", comentario);


                db.ExecuteNonQuery(comando);
            }
        }

        public static void ActualizarRelacionRepartidor(Factura _Factura, double puntaje, string comentario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarFacturaRepartidor";
                comando.Parameters.AddWithValue("@idRepartidor", _Factura._Repartidor.Id);
                comando.Parameters.AddWithValue("@idFactura", _Factura.Id);
                comando.Parameters.AddWithValue("@puntaje", puntaje);
                comando.Parameters.AddWithValue("@comentario", comentario);


                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Ingrese un nuevo registro de cupon usado
        /// </summary>
        /// <param name="cliente">El cliente que usó el cupón</param>
        /// <param name="cupon">El cupón usado</param>
        public static void InsertarCuponUsado(Cliente cliente, Cupon cupon)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarCuponUsado";
                comando.Parameters.AddWithValue("@CUPON_ID", cupon.Id);
                comando.Parameters.AddWithValue("@USUARIO_ID", cliente.Id);


                db.ExecuteNonQuery(comando);
            }
        }

        public static Factura SeleccionarFacturaPorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarFacturaPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Factura factura = new Factura();

                    factura.Id = (int) dr["ID"];
                    factura._Negocio = UsuarioDB.SeleccionarNegocioPorFacturaID((int)dr["ID"]);
                    factura._Cliente = UsuarioDB.SeleccionarClientePorFacturaID((int)dr["ID"]);
                    factura._Repartidor = UsuarioDB.SeleccionarRepartidorPorFacturaID((int)dr["ID"]);
                    factura._Pedido = PedidoDB.PA_SeleccionarPedidoPorFacturaID((int)dr["ID"]);
                    factura.Fecha = (DateTime)dr["FECHA"];
                    factura.Estado_Factura = dr["ESTADO_FACTURA"].ToString();
                    factura.Estado_Pedido = dr["ESTADO_PEDIDO"].ToString();
                    factura.Estado_Calificacion = dr["ESTADO_CALIFICACION"].ToString();

                    return factura;


                }
            }
            return null;
        }

        public static  List<Factura> SeleccionarFacturaPorNegocioID(int id)
        {
            List<Factura> lista = new List<Factura>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarFacturaPorNegocio";
                comando.Parameters.AddWithValue("@Negocio_ID", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Factura factura = SeleccionarFacturaPorID((int)dr["ID"]);
                    lista.Add(factura);
                }
            }

            return lista;
        }
        public static void CambiarEstado(int id, string estado)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_CambiarEstadoPedido";
                comando.Parameters.AddWithValue("@idFactura", id);
                comando.Parameters.AddWithValue("@estado", estado);

                db.ExecuteNonQuery(comando);
            }
        }

        public static void CambiarEstadoCalificacion(int id, string estado)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarEstadoCalificadoFactura";
                comando.Parameters.AddWithValue("@idFactura", id);
                comando.Parameters.AddWithValue("@estado", estado);

                db.ExecuteNonQuery(comando);
            }
        }

        public static List<Factura> ObtenerFacturasListas()
        {
            List<Factura> lista = new List<Factura>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPedidosListos";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Factura factura = SeleccionarFacturaPorID((int)dr["ID"]);
                    lista.Add(factura);
                }
            }

            return lista;
        }

        public static Factura ObtenerFacturaSinCalificar(int idCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarFacturaSinCalificar";
                comando.Parameters.AddWithValue("@idCliente", idCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Factura factura = SeleccionarFacturaPorID((int)dr["ID"]);
                    // factura.Estado_Pedido.ToLower().Equals("entregado") && 
                    if (factura.Estado_Calificacion.ToLower().Equals("sin calificar") )
                        return factura;
                }
            }

            return null;
        }



    }
}
