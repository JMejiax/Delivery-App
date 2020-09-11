using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Factory
{
    /// <summary>
    /// Clase cuya función es contruir el objeto Articulo
    /// </summary>
    public class FactoryArticulo
    {
        /// <summary>
        /// Propiedad que almacena el objeto Articulo
        /// </summary>
        Articulo _Articulo  = null;

        /// <summary>
        /// Crea la instancia al articulo dependiendo del tipo de articulo
        /// </summary>
        /// <param name="ta">Enum Tipo articulo</param>
        /// <returns>Objeto tipo Articulo</returns>
        public Articulo CrearArticulo(TipoArticulo ta)
        {
            if (ta == TipoArticulo.Producto) _Articulo = new Producto();
            if (ta == TipoArticulo.CuponDescuento) _Articulo = new CupoDescuento();
            if (ta == TipoArticulo.CuponProductoGratis) _Articulo = new CuponProductoGratis();

            return _Articulo;
        }
    }
}
