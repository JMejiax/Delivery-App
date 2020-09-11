using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase padre que hereda de la clase Articulo
    /// </summary>
    public class Cupon: Articulo
    {
        /// <summary>
        /// Propiedad que almacena el código QR del cupón
        /// </summary>
        public string Codigo_QR { get; set; }

        /// <summary>
        /// Propiedad que almacena la fecha de vencimiento del cupón
        /// </summary>
        public DateTime FechaVencimiento { get; set; }

        /// <summary>
        /// Propiedad que almacena el estado del cupón
        /// </summary>
        public bool Estado { get; set; }
    }
}
