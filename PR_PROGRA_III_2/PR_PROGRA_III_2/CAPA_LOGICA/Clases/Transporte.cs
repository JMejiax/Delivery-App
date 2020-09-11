using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// 
    /// </summary>
    public class Transporte
    {
        /// <summary>
        /// Propiedad que almacena ID del Transporte
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propiedad que almacena la marca del Transporte
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// Propiedad que almacena estado del Transporte
        /// </summary>
        public string Activo { get; set; }

        /// <summary>
        /// Propiedad que almacena modelo del Transporte
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Propiedad que almacena color del Transporte
        /// </summary>
        public string Color { get; set; }

    }
}
