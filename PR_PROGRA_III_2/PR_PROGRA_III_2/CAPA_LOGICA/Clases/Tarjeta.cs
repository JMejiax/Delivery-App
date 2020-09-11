using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que contiene la definicón del objeto Tarjeta
    /// </summary>
    public class Tarjeta
    {
        /// <summary>
        /// Propiedad que almacena el ID de la tarjeta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propiedad que almacena el CVV de la tarjeta
        /// </summary>
        public string cvv { get; set; }

        /// <summary>
        /// Propiedad que almacena numero de tarjeta
        /// </summary>
        public string numero { get; set; }

        /// <summary>
        /// Propiedad que almacena la fecha de vencimiento de la tarjeta
        /// </summary>
        public DateTime FechaVencimiento { get; set; }

        /// <summary>
        /// Propiedad que almacena el tipo de tarjeta
        /// </summary>
        public TipoTarjeta _TipoTarjeta { get; set; }

    }
}
