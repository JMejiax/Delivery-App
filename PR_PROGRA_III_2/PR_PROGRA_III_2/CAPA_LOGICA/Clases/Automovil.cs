using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que hereda de Transporte
    /// </summary>
    public class Automovil: Transporte
    {
        /// <summary>
        /// Propiedad que guarda el número de placa del transporte tipo Automovil
        /// </summary>
        public string Placa { get; set; }

        /// <summary>
        /// Propiedad que guarda si el automovil está al dia o no
        /// </summary>
        public bool AlDia { get; set; }
    }
}
