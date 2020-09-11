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
    public class Bicicleta: Transporte
    {
        /// <summary>
        /// Propiedad que guarda el tipo de bicicleta
        /// </summary>
        public TipoBicicleta _TipoBicicleta { get; set; }
    }
}
