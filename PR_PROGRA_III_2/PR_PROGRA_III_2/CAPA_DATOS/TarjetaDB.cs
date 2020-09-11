using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class TarjetaDB
    {
        /// <summary>
        /// Guarda una tarjeta nueva en la base de datos
        /// </summary>
        ///<param name="tarjeta">Objeto Tarjeta</param>
        public static void Insertar(Tarjeta tarjeta)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarTarjeta";
                comando.Parameters.AddWithValue("@CVV", tarjeta.cvv);
                comando.Parameters.AddWithValue("@NUMERO_TARJETA", tarjeta.numero);
                comando.Parameters.AddWithValue("@FECHA_VENCIMIENTO", tarjeta.FechaVencimiento);
                comando.Parameters.AddWithValue("@TIPO_TARJETA_ID", (tarjeta._TipoTarjeta.Equals(TipoTarjeta.VISA) ? 1 : 2));

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza los datos de una tarjeta
        /// </summary>
        ///<param name="tarjeta">Objeto Tarjeta</param>
        public static void Actualizar(Tarjeta tarjeta)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarTarjeta";
                comando.Parameters.AddWithValue("@id", tarjeta.Id);
                comando.Parameters.AddWithValue("@CVV", tarjeta.cvv);
                comando.Parameters.AddWithValue("@NUMERO_TARJETA", tarjeta.numero);
                comando.Parameters.AddWithValue("@FECHA_VENCIMIENTO", tarjeta.FechaVencimiento);
                comando.Parameters.AddWithValue("@TIPO_TARJETA_ID", (tarjeta._TipoTarjeta.Equals(TipoTarjeta.VISA) ? 1 : 2));

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Se encarga de obtener la tarjeta que se quiere consultar
        /// </summary>
        ///<param name="id">EL ID unico de la tarjeta</param>
        ///<returns>Un objeto de tipo tarjeta</returns>
        public static Tarjeta SeleccionarPorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTarjetaPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Tarjeta tarjeta = new Tarjeta();
                    tarjeta.Id = (int)dr["TARJETA_ID"];
                    tarjeta.cvv = dr["CVV"].ToString();
                    tarjeta.numero = dr["NUMERO_TARJETA"].ToString();
                    tarjeta.FechaVencimiento = (DateTime) dr["FECHA_VENCIMIENTO"];
                    tarjeta._TipoTarjeta = SeleccionarTipoTarjetaPorID((int)dr["TIPO_TARJETA_ID"]);
                    return tarjeta;
                }
            }
            return null;
        }

        /// <summary>
        /// Se encarga de obtener el tipo de tarjeta que se está consultando
        /// </summary>
        ///<param name="id">EL ID unico de la tarjeta</param>
        ///<returns>Un enum del tipo de tarjeta</returns>
        public static TipoTarjeta SeleccionarTipoTarjetaPorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoTarjetaPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoTarjeta tp;
                    string tipo = dr["TIPO_TARJETA"].ToString();
                    if(tipo.ToLower().Equals("visa"))
                        tp = TipoTarjeta.VISA;
                    else
                        tp = TipoTarjeta.MASTERCARD;                    
                    return tp;
                }
            }
            return TipoTarjeta.DESCONOCIDA;
        }
    }
}
