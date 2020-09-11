using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que hereda de Articulo
    /// </summary>
    public class Producto: Articulo
    {
        /// <summary>
        /// Propiedad que almacena el precio unitario del producto
        /// </summary>
        public double Precio { get; set; }

        /// <summary>
        /// Propiedad que almacena la cantidad de productos sseleccionados por el usuario
        /// </summary>
        public int Cantidad { get; set; }

        /// <summary>
        /// Calcula el costo total del producto en relacion cantidad - precio
        /// </summary>
        /// <returns>Retorna el costo total del producto</returns>
        public double Costo()
        {
            return Precio * Cantidad;
        }
    }
}
