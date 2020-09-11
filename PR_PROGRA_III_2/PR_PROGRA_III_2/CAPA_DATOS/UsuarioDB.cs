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
    public class UsuarioDB
    {
        #region Cliente
        /// <summary>
        /// Inserta un nuevo usuario de tipo cliente a la base de datos
        /// </summary>
        ///<param name="cliente">Objeto de tipo Cliente</param>
        public static void InsertarCliente(Cliente cliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarCliente";
                comando.Parameters.AddWithValue("@CEDULA", cliente.Cedula);
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", cliente.Nombre);
                comando.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                comando.Parameters.AddWithValue("@NUMERO_TELEFONO", cliente.NumeroTelefono);
                comando.Parameters.AddWithValue("@CORREO_ELECTRONICO", cliente.Correo);
                comando.Parameters.AddWithValue("@CONTRASENNA", cliente.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualizar los datos de un usuario de tipo cliente
        /// </summary>
        ///<param name="cliente">Objeto de tipo Cliente</param>
        public static void ActualizarCliente(Cliente cliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {

                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCliente";
                comando.Parameters.AddWithValue("@id", cliente.Id);
                comando.Parameters.AddWithValue("@CEDULA", cliente.Cedula);
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", cliente.Nombre);
                comando.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                comando.Parameters.AddWithValue("@NUMERO_TELEFONO", cliente.NumeroTelefono);
                comando.Parameters.AddWithValue("@CORREO_ELECTRONICO", cliente.Correo);
                comando.Parameters.AddWithValue("@CONTRASENNA", cliente.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Obtiene el cliente de la base de datos de acuerdo al id de la factura
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cliente SeleccionarClientePorFacturaID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarIdClientePorFacturaID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente _Cliente = new Cliente();
                    _Cliente = (Cliente)SeleccionarPorCorreo(dr["CORREO_ELECTRONICO"].ToString());
                    return _Cliente;
                }
            }
            return null;
        }

        #endregion Cliente

        #region NEGOCIO

        /// <summary>
        /// Inserta un nuevo usuario de tipo negocio a la base de datos
        /// </summary>
        ///<param name="cliente">Objeto de tipo Cliente</param>
        public static void InsertarNegocio(Negocio negocio)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {

                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarNegocio";
                comando.Parameters.AddWithValue("@CEDULA", negocio.Cedula);
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", negocio.Nombre);
                comando.Parameters.AddWithValue("@NUMERO_TELEFONO", negocio.NumeroTelefono);
                comando.Parameters.AddWithValue("@CORREO_ELECTRONICO", negocio.Correo);
                comando.Parameters.AddWithValue("@CONTRASENNA", negocio.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualizar los datos de un usuario de tipo negocio
        /// </summary>
        ///<param name="negocio">Objeto de tipo Negocio</param>
        public static void ActualizarNegocio(Negocio negocio)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {

                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarNegocio";
                comando.Parameters.AddWithValue("@id", negocio.Id);
                comando.Parameters.AddWithValue("@CEDULA", negocio.Cedula);
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", negocio.Nombre);
                comando.Parameters.AddWithValue("@NUMERO_TELEFONO", negocio.NumeroTelefono);
                comando.Parameters.AddWithValue("@CORREO_ELECTRONICO", negocio.Correo);
                comando.Parameters.AddWithValue("@CONTRASENNA", negocio.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Obtiene el negocio de la base de datos de acuerdo al id de la factura
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Negocio SeleccionarNegocioPorFacturaID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarIdNegocioPorFacturaID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Negocio _Negocio = new Negocio();
                    _Negocio = (Negocio)SeleccionarPorCorreo(dr["CORREO_ELECTRONICO"].ToString());
                    return _Negocio;
                }
            }
            return null;
        }


        /// <summary>
        /// Obtener una lista con los negocios disponibles
        /// </summary>
        /// <returns>Lista de tipo Negocio</returns>
        public static List<Negocio> ObtenerNegocios()
        {
            List<Negocio> lista = new List<Negocio>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ListaNegocios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Negocio _Negocio = new Negocio();
                    _Negocio = (Negocio)SeleccionarPorCorreo(dr["CORREO_ELECTRONICO"].ToString());
                    if(_Negocio != null)
                        lista.Add(_Negocio);
                }
            }

            return lista;
        }

        #endregion NEGOCIO

        #region REPARTIDOR

        /// <summary>
        /// Inserta un nuevo repartidor a la base de datos
        /// </summary>
        ///<param name="repartidor">Objeto de tipo Cliente</param>
        public static void InsertarRepartidor(Repartidor repartidor)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_IngresarRepartidor";
                comando.Parameters.AddWithValue("@CEDULA", repartidor.Cedula);
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", repartidor.Nombre);
                comando.Parameters.AddWithValue("@APELLIDOS", repartidor.Apellidos);
                comando.Parameters.AddWithValue("@NUMERO_TELEFONO", repartidor.NumeroTelefono);
                comando.Parameters.AddWithValue("@CORREO_ELECTRONICO", repartidor.Correo);
                comando.Parameters.AddWithValue("@CONTRASENNA", repartidor.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza la información de un repartidor
        /// </summary>
        /// <param name="repartidor"></param>
        public static void ActualizarRepartidor(Repartidor repartidor)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarRepartidor";
                comando.Parameters.AddWithValue("@id", repartidor.Id);
                comando.Parameters.AddWithValue("@CEDULA", repartidor.Cedula);
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", repartidor.Nombre);
                comando.Parameters.AddWithValue("@APELLIDOS", repartidor.Apellidos);
                comando.Parameters.AddWithValue("@NUMERO_TELEFONO", repartidor.NumeroTelefono);
                comando.Parameters.AddWithValue("@CORREO_ELECTRONICO", repartidor.Correo);
                comando.Parameters.AddWithValue("@CONTRASENNA", repartidor.Contrasenna);
                comando.Parameters.AddWithValue("@TRANSPORTEID", repartidor._Transporte.Id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Obtiene el repartidor de la base de datos de acuerdo al id de la factura
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Repartidor SeleccionarRepartidorPorFacturaID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarRepartidorPorFacturaID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Repartidor _Repartidor = new Repartidor();
                    _Repartidor = (Repartidor)SeleccionarPorCorreo(dr["CORREO_ELECTRONICO"].ToString());
                    return _Repartidor;
                }
            }
            return null;
        }

        #endregion REPARTIDOR

        #region METODOS GENERALES

        /// <summary>
        /// Obtener una lista con todos los usuarios de la aplicación
        /// </summary>
        /// <returns>Lista de tipo Usuario</returns>
        public static List<Usuario> SeleccionarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarUsuarios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    Usuario usuario = SeleccionarPorCorreo(dr["CORREO_ELECTRONICO"].ToString());
                    
                    lista.Add(usuario);
                }
            }

            return lista;
        }

        /// <summary>
        /// Se encarga de obtener el usuario por medio de su correo
        /// </summary>
        ///<param name="correo">EL correo único del usuario</param>
        ///<returns>Un objeto de tipo Usuario</returns>
        public static Usuario SeleccionarPorCorreo(string correo)
        {            
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarUsuarioPorCorreo";
                comando.Parameters.AddWithValue("@correo", correo);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario usuario = null;
                    // Si el usuario está inactivo, retorna null
                    if ((dr["ACTIVO"].ToString().ToLower().Equals("inactivo")))
                        break;

                    // Se construye el usuario dependiendo de su tipo
                    FactoryUsuario fu = new FactoryUsuario();
                    usuario = fu.CrearUsuario(SeleccionarTipoUsuarioPorID((int)dr["TIPO_USUARIO_ID"]));

                    // Se agregan las propiedades única de cada usuario
                    if (usuario is Cliente)
                        (usuario as Cliente).Apellidos = dr["APELLIDOS"].ToString();

                    if (usuario is Repartidor) {
                        (usuario as Repartidor).PuntajeTotal = PuntajeTotal((int)dr["USUARIO_ID"]);
                        (usuario as Repartidor).Apellidos = dr["APELLIDOS"].ToString();
                        (usuario as Repartidor)._Transporte = TransporteDB.SeleccionarTransportePorID((int)dr["TRANSPORTE_ID"]);
                        (usuario as Repartidor).ListaCalificacion = CalificacionDB.ObtenerCalificacionesPorIDUsuario((int)dr["USUARIO_ID"]);
                    }

                    if (usuario is Negocio)
                    {
                        (usuario as Negocio).PuntajeTotal = PuntajeTotal((int)dr["USUARIO_ID"]);
                        (usuario as Negocio).ListaCalificacion = CalificacionDB.ObtenerCalificacionesPorIDUsuario((int)dr["USUARIO_ID"]);
                        (usuario as Negocio).ListaProductos = ArticuloDB.ObtenerArticulosPorIDUsuario((int)dr["USUARIO_ID"]);
                    }

                    if (usuario is Admin)
                    {
                        (usuario as Admin).Id = (int)dr["USUARIO_ID"];
                        (usuario as Admin).Cedula = dr["CEDULA"].ToString();
                        (usuario as Admin).Nombre = dr["NOMBRE_USUARIO"].ToString();
                        (usuario as Admin).Correo = dr["CORREO_ELECTRONICO"].ToString();
                        (usuario as Admin).Contrasenna = usuario.Contrasenna = dr["CONTRASENNA"].ToString();
                        (usuario as Admin).Activo = (dr["ACTIVO"].ToString().ToLower().Equals("activo"));
                        return usuario;
                    }

                    // Se agregan las propiedades generales de un usuario
                    usuario.Id = (int)dr["USUARIO_ID"];
                    usuario.Cedula = dr["CEDULA"].ToString();
                    usuario.Nombre = dr["NOMBRE_USUARIO"].ToString();
                    usuario.NumeroTelefono = dr["NUMERO_TELEFONO"].ToString();
                    usuario._Direccion = DireccionDB.SeleccionarPorID((int)dr["DIRECCION_ID"]);
                    usuario.Correo = dr["CORREO_ELECTRONICO"].ToString();
                    usuario.Contrasenna = dr["CONTRASENNA"].ToString();
                    usuario._Tarjeta = TarjetaDB.SeleccionarPorID((int)dr["TARJETA_CREDITO_ID"]);
                    usuario.Activo = (dr["ACTIVO"].ToString().ToLower().Equals("activo"));
                    return usuario;
                    
                }
            }
            return null;
        }

        /// <summary>
        /// Se encarga de obtener el tipo de usuario que se está consultando
        /// </summary>
        ///<param name="id">EL ID unico del usuario</param>
        ///<returns>Un string con el nombre del tipo de usuario</returns>
        public static TipoUsuario SeleccionarTipoUsuarioPorID(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoUsuarioPorID";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string tipo = dr["TIPO_USUARIO"].ToString();
                    if (tipo.ToLower().Equals("cliente")) return TipoUsuario.Cliente;
                    if (tipo.ToLower().Equals("negocio")) return TipoUsuario.Negocio;
                    if (tipo.ToLower().Equals("repartidor")) return TipoUsuario.Repartidor;
                }
            }
            return TipoUsuario.Admin;
        }

        /// <summary>
        /// Deshabilita el usuario
        /// </summary>
        ///<param name="id">EL ID unico del usuario</param>
        public static void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_DeshabilitarUsuario";
                comando.Parameters.AddWithValue("@id", id);                

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Obtiene el puntaje total del negocio o repartidor
        /// </summary>
        ///<param name="id">EL ID unico del negocio o repartidor</param>
        public static double PuntajeTotal(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_PuntajeTotal";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if(!dr[0].ToString().Equals(""))
                    return Convert.ToDouble(((double)dr[0]).ToString("0.##"));
                }
            }
            return 10.0d;
        }
        #endregion METODOS GENERALES
    }
}
