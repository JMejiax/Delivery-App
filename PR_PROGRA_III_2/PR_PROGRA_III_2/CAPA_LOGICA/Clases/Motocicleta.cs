using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    // Clase que hereda de Transporte
    public class Motocicleta: Transporte
    {
        /// <summary>
        /// Propiedad que guarda el número de placa del transporte tipo Motocicleta
        /// </summary>
        public string Placa { get; set; }

        /// <summary>
        /// Propiedad que guarda si la motocicleta está al dia o no
        /// </summary>
        public bool AlDia { get; set; }
    }
}
