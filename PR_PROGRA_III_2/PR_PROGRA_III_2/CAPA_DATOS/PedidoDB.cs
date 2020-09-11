using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Facade;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class PedidoDB
    {
        /// <summary>
        /// Guarda un pedido nuevo en la base de datos
        /// </summary>
        ///<param name="_Producto">Objeto Factura</param>
        public static void Insertar(Producto _Producto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarPedido";
                comando.Parameters.AddWithValue("@ARTICULO_ID", _Producto.Id);
                comando.Parameters.AddWithValue("@CANTIDAD", _Producto.Cantidad);
                comando.Parameters.AddWithValue("@COSTO", _Producto.Costo());


                db.ExecuteNonQuery(comando);
            }
        }

        public static FacadePedido PA_SeleccionarPedidoPorFacturaID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPedidoPorFacturaID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    FacadePedido pedido = new FacadePedido(); ;
                    pedido.ListaProductos = PA_SeleccionarDetalleFactura(id);
                    pedido._Cupon = PA_SeleccionarCuponPorFacturaID(id);
                    return pedido;

                }
            }
            return null;
        }

        public static List<Producto> PA_SeleccionarDetalleFactura(int id)
        {
            List<Producto> lista = new List<Producto>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPedidoPorFacturaID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto prod = (Producto) ArticuloDB.SeleccionarPorId((int)dr["ARTICULO_ID"]);
                    prod.Cantidad = (int)dr["CANTIDAD"];
                    lista.Add(prod);
                }
            }

            return lista;
        }

        public static Cupon PA_SeleccionarCuponPorFacturaID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarIdCuponPorFacturaID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cupon cupon = (Cupon)ArticuloDB.SeleccionarPorId((int)dr["ARTICULO_ID"]);
                    
                }
            }

            return null;
        }
    }
}
