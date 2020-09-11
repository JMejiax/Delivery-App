using CAPA_ENTIDADES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase heredada de Cupon y de la interfaz IDescuento
    /// </summary>
    public class CupoDescuento : Cupon, IDescuento
    {
        /// <summary>
        /// Propiedad que almacena el porcentaje de descuento del cupón
        /// </summary>
        public double PorcentajeDescuento { get ; set ; }
    }
}
