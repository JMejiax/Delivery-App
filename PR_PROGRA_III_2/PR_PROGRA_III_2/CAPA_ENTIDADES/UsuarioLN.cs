using CAPA_DATOS;
using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LN
{
    public class UsuarioLN
    {

        public Usuario ConsultarUsuario(string correo)
        {
            return UsuarioDB.SeleccionarPorCorreo(correo);
        }

        public List<Negocio> ObtenerListaNegocios()
        {
            return UsuarioDB.ObtenerNegocios();
        }

        #region INGRESAR USUARIOS
        public void IngresarCliente(Cliente cliente)
        {
            UsuarioDB.InsertarCliente(cliente);
        }

        public void IngresarNegocio(Negocio negocio)
        {
            UsuarioDB.InsertarNegocio(negocio);
        }

        public void IngresarRepartidor(Repartidor rep)
        {
            UsuarioDB.InsertarRepartidor(rep);
        }
        #endregion INGRESAR USUARIOS

        #region ACTUALIZAR USUARIOS
        public void ActualizarCliente(Cliente cliente)
        {
            UsuarioDB.ActualizarCliente(cliente);
        }
        public void ActualizarNegocio(Negocio negocio)
        {
            UsuarioDB.ActualizarNegocio(negocio);
        }
        public void ActualizarRepartidor(Repartidor rep)
        {
            UsuarioDB.ActualizarRepartidor(rep);
        }

        #endregion ACTUALIZAR USUARIOS

        public void EliminarUsuario(int id)
        {
            UsuarioDB.Eliminar(id);
        }

        public List<Usuario> SeleccionarTodos()
        {
            return UsuarioDB.SeleccionarTodos();
        }

    }
}
