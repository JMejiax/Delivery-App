using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Interfaces
{
    /// <summary>
    /// Interfaz Descuento
    /// </summary>
    public interface IDescuento
    {
        /// <summary>
        /// Procentaje de descuento
        /// </summary>
        double PorcentajeDescuento { get; set; }
    }
}
