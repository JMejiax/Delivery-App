using CAPA_ENTIDADES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que hereda de Cupon y la interfaz IProductoGratis
    /// </summary>
    public class CuponProductoGratis : Cupon, IProductoGratis
    {
        /// <summary>
        /// Propiedad que almacena el ID del producto que hace gratis
        /// </summary>
        public int IDProducto { get ; set ; }
    }
}
