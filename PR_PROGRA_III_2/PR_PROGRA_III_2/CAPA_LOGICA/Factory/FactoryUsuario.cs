using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Factory
{
    /// <summary>
    /// Clase cuya función es contruir el objeto Usuario
    /// </summary>
    public class FactoryUsuario
    {
        /// <summary>
        /// Propiedad que almacena el objeto Usuario
        /// </summary>
        Usuario _Usuario = null;

        /// <summary>
        /// Crea la instancia al Usuario dependiendo del tipo de usuario
        /// </summary>
        /// <param name="tUsuario">Enum tipo usuario</param>
        /// <returns>Objeto tipo Usuario</returns>
        public Usuario CrearUsuario(TipoUsuario tUsuario)
        {
            if (tUsuario == TipoUsuario.Cliente) _Usuario = new Cliente();
            if (tUsuario == TipoUsuario.Negocio) _Usuario = new Negocio();
            if (tUsuario == TipoUsuario.Repartidor) _Usuario = new Repartidor();
            if (tUsuario == TipoUsuario.Admin) _Usuario = new Admin();
            return _Usuario;
        }
    }
}
