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
    public class CalificacionDB
    {
        /// <summary>
        /// Se encarga de obtener una lista de objetos tipo Calificacion
        /// </summary>
        ///<param name="id">EL ID unico del usuario</param>
        ///<returns>Una lista de Calificaciones</returns>
        public static List<Calificacion> ObtenerCalificacionesPorIDUsuario(int id)
        {
            List<Calificacion> lista = new List<Calificacion>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCalificacionPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (!dr["PUNTAJE"].ToString().Equals("")) {
                        Calificacion ca = new Calificacion();
                        ca.puntaje = (double)dr["PUNTAJE"];
                        ca.comentario = dr["COMENTARIO"].ToString();

                        lista.Add(ca);
                    }
                }
            }
            return lista;
        }
    }
}
