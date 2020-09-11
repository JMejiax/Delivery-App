using System;
using System.Configuration;
using System.Text;


class FactoryConexion
{
    public static string CreateConnection()
    {        
        // Lee la conexion default
        return ConfigurationManager.ConnectionStrings["Capa_UI.Properties.Settings.Cadena"].ConnectionString;             
    }

    public static string CreateConnection(string nombre)
    {
        // Lee la conexion default
        return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
    }

    public static string CreateConnection(string pUsuario, String pContrasena)
    {
        StringBuilder conexion = new StringBuilder();
        // Lee la conexion default
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["Capa.UI.Properties.Settings.Cadena"].ConnectionString);
        // Agrega al usuario
        conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
        return conexion.ToString();
    }

    public static string CreateConnection(string server, string nombreDB, string pUsuario, String pContrasena)
    {
        StringBuilder conexion = new StringBuilder();
        conexion.AppendFormat("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", server, nombreDB, pUsuario, pContrasena);
        return conexion.ToString();
    }

}

