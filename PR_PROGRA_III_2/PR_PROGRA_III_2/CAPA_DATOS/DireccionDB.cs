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
    public class DireccionDB
    {
        /// <summary>
        /// Guarda una dirección nueva en la base de datos
        /// </summary>
        ///<param name="direccion">Objeto direccion</param>
        public static void Insertar(Direccion direccion)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {                
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarDireccion";
                comando.Parameters.AddWithValue("@LATITUD", direccion.latitud);
                comando.Parameters.AddWithValue("@LONIGTUD", direccion.longitud);
                comando.Parameters.AddWithValue("@DIRECCION_EXACTA", direccion.Descripcion);
             

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza la informacion de una direccion
        /// </summary>
        ///<param name="direccion">Objeto direccion</param>
        public static void Actualizar(Direccion direccion)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarDireccion";
                comando.Parameters.AddWithValue("@id", direccion.Id);
                comando.Parameters.AddWithValue("@LATITUD", direccion.latitud);
                comando.Parameters.AddWithValue("@LONIGTUD", direccion.longitud);
                comando.Parameters.AddWithValue("@DIRECCION_EXACTA", direccion.Descripcion);


                db.ExecuteNonQuery(comando);
            }
        }
        /// <summary>
        /// Se encarga de crear el objeto Direccion con la información de la base de datos
        /// </summary>
        ///<param name="id">EL ID unico de la dirección</param>
        ///<returns>Un objeto de tipo Direccion</returns>
        public static Direccion SeleccionarPorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarDireccionPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Direccion direccion = new Direccion();
                    direccion.Id = (int)dr["DIRECCION_ID"];
                    direccion.latitud = dr["LATITUD"].ToString();
                    direccion.longitud = dr["LONIGTUD"].ToString();
                    direccion.Descripcion = dr["DIRECCION_EXACTA"].ToString();
                    return direccion;
                }
            }
            return null;
        }
    }
}
