using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase padre para Articulos
    /// </summary>
    public class Articulo
    {
        /// <summary>
        /// Propiedad que guarda el ID único del articulo
        /// </summary>
        public int Id {get; set;}

        /// <summary>
        /// Propiedad que guarda el ID único del negocio al que pertenece el articulo
        /// </summary>
        public int UsuarioId {get; set; }

        /// <summary>
        /// Propiedad que guarda el nombre del articulo
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propiedad que guarda la descripcion del articulo
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Propiedad que guarda la imagen del articulo
        /// </summary>
        public Image Fotografia { get; set; }

        /// <summary>
        /// Propiedad para determinar si el articulo esta activo o no
        /// </summary>
        public bool Activo { get; set; }
    }
}
