using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class TransporteDB
    {

        #region INSERTAR

        /// <summary>
        /// Ingresa una nueva bicicleta a la base de datos
        /// </summary>
        /// <param name="bici"></param>
        public static void IngresarBicicleta(Bicicleta bici)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarBicicleta";
                comando.Parameters.AddWithValue("@MARCA", bici.Marca);
                comando.Parameters.AddWithValue("@MODELO", bici.Modelo);
                comando.Parameters.AddWithValue("@COLOR", bici.Color);
                comando.Parameters.AddWithValue("@TIPO_BICICLETA", bici._TipoBicicleta.ToString());
                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Ingresa un nuevo carro a la base de datos
        /// </summary>
        /// <param name="auto"></param>
        public static void IngresarAuto(Automovil auto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarCarro";
                comando.Parameters.AddWithValue("@MARCA", auto.Marca);
                comando.Parameters.AddWithValue("@MODELO", auto.Modelo);
                comando.Parameters.AddWithValue("@COLOR", auto.Color);
                comando.Parameters.AddWithValue("@PLACA", auto.Placa);
                comando.Parameters.AddWithValue("@ALDIA", auto.AlDia.ToString());
                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Ingresa una nueva moto a la base de datos
        /// </summary>
        /// <param name="moto"></param>
        public static void IngresarMoto(Motocicleta moto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarMoto";
                comando.Parameters.AddWithValue("@MARCA", moto.Marca);
                comando.Parameters.AddWithValue("@MODELO", moto.Modelo);
                comando.Parameters.AddWithValue("@COLOR", moto.Color);
                comando.Parameters.AddWithValue("@PLACA", moto.Placa);
                comando.Parameters.AddWithValue("@ALDIA", moto.AlDia.ToString());
                db.ExecuteNonQuery(comando);
            }
        }

        #endregion INSERTAR

        #region ACTUALIZAR

        /// <summary>
        /// Actualiza la información de una bicicleta
        /// </summary>
        /// <param name="bici"></param>
        public static void ActualizarBicicleta(Bicicleta bici)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarBicicleta";
                comando.Parameters.AddWithValue("@id", bici.Id);
                comando.Parameters.AddWithValue("@MARCA", bici.Marca);
                comando.Parameters.AddWithValue("@MODELO", bici.Modelo);
                comando.Parameters.AddWithValue("@COLOR", bici.Color);
                comando.Parameters.AddWithValue("@TIPO", bici._TipoBicicleta.ToString());
                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza la información de un auto
        /// </summary>
        /// <param name="auto"></param>
        public static void ActualizarAuto(Automovil auto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarMotoOCarro";
                comando.Parameters.AddWithValue("@id", auto.Id);
                comando.Parameters.AddWithValue("@MARCA", auto.Marca);
                comando.Parameters.AddWithValue("@MODELO", auto.Modelo);
                comando.Parameters.AddWithValue("@COLOR", auto.Color);
                comando.Parameters.AddWithValue("@PLACA", auto.Placa);
                comando.Parameters.AddWithValue("@ALDIA", auto.AlDia.ToString());
                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza la información de una moto
        /// </summary>
        /// <param name="moto"></param>
        public static void ActualizarMoto(Motocicleta moto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarMotoOCarro";
                comando.Parameters.AddWithValue("@id", moto.Id);
                comando.Parameters.AddWithValue("@MARCA", moto.Marca);
                comando.Parameters.AddWithValue("@MODELO", moto.Modelo);
                comando.Parameters.AddWithValue("@COLOR", moto.Color);
                comando.Parameters.AddWithValue("@PLACA", moto.Placa);
                comando.Parameters.AddWithValue("@ALDIA", moto.AlDia.ToString());
                db.ExecuteNonQuery(comando);
            }
        }


        #endregion ACTUALIZAR


        /// <summary>
        /// Se encarga de seleccionar un Transporte de acuerdo al ID ingresado
        /// </summary>
        ///<param name="id">EL ID unico del Transporte a consultar</param>
        ///<returns>Objeto de tipo Transporte</returns>
        public static Transporte SeleccionarTransportePorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTransportePorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Transporte transporte = null;
                    
                    TipoTransporte tp = SeleccionarTipoTransportePorID((int)dr["TIPO_TRANSPORTE_ID"]);

                    //Se crea el objeto transporte de acuerdo a su tipo
                    FactoryTransporte ft = new FactoryTransporte();
                    transporte = ft.CrearTransporte(tp);
                    
                    // Se agregan las propiedades especificas de cada transporte
                    if(transporte is Bicicleta)
                        (transporte as Bicicleta)._TipoBicicleta = (dr["TIPO_BICICLETA"].ToString().ToLower().Equals("bmx")) ? TipoBicicleta.BMX : TipoBicicleta.MTB;

                    if (transporte is Automovil)
                    {
                        (transporte as Automovil).Placa = dr["PLACA"].ToString();
                        (transporte as Automovil).AlDia = dr["ALDIA"].ToString().ToLower().Equals("true");
                    }

                    if (transporte is Motocicleta)
                    {
                        (transporte as Motocicleta).Placa = dr["PLACA"].ToString();
                        (transporte as Motocicleta).AlDia = dr["ALDIA"].ToString().ToLower().Equals("true");
                    }
                    
                    //Propiedades generales del objeto
                    transporte.Id = (int)dr["TRANSPORTE_ID"];
                    transporte.Marca = dr["MARCA"].ToString();
                    transporte.Modelo = dr["MODELO"].ToString();
                    transporte.Color = dr["COLOR"].ToString();
                    transporte.Activo = dr["Activo"].ToString();
                    return transporte;
                }
            }
            return null;
        }

        /// <summary>
        /// Se encarga de seleccionar el tipo transporte de acuerdo al ID ingresado
        /// </summary>
        ///<param name="id">EL ID unico del Tipo de Transporte a consultar</param>
        ///<returns>Enum TipoTransporte</returns>
        public static TipoTransporte SeleccionarTipoTransportePorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoTransportePorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string tp = dr["TIPO_TRANSPORTE"].ToString().ToUpper();

                    if (tp.Equals("BICICLETA")) return TipoTransporte.Bicicleta;

                    else if (tp.Equals("MOTOCICLETA")) return TipoTransporte.Motocicleta;

                    else return TipoTransporte.Automovil;
                }
            }
            return TipoTransporte.Desconocido;
        }

        /// <summary>
        /// Deshabilita el transporte
        /// </summary>
        ///<param name="id">EL ID unico del transporte</param>
        public static void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarTransporte";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }
    }
}
