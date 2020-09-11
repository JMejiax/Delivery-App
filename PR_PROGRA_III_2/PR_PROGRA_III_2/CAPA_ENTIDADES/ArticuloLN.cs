using CAPA_DATOS;
using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LN
{
    public class ArticuloLN
    {
        #region INSERTAR
        public void InsertarProducto(Producto prod, int idNegocio)
        {
            ArticuloDB.InsertarProducto(prod, idNegocio);
        }

        public void InsertarCuponDescuento(CupoDescuento cupon, int NegocioID)
        {
            ArticuloDB.InsertarCuponDescuento(cupon, NegocioID);
        }

        public void InsertarCuponProd(CuponProductoGratis cupon, int NegocioID)
        {
            ArticuloDB.InsertarCuponProd(cupon, NegocioID);
        }

        #endregion INSERTAR

        #region ACTUALIZAR
        public void ActualizarProducto(Producto prod)
        {
            ArticuloDB.ActualizarProducto(prod);
        }
        
        public void ActualizarCuponDescuento(CupoDescuento cupon)
        {
            ArticuloDB.ActualizarCuponDescuento(cupon);
        }
        
        public void ActualizarCuponProd(CuponProductoGratis cupon)
        {
            ArticuloDB.ActualizarCuponProd(cupon);
        }

        #endregion ACTUALIZAR

        public void Eliminar(int id)
        {
            ArticuloDB.Eliminar(id);
        }

        public Articulo ObtenerProducto(int id)
        {
            return ArticuloDB.SeleccionarPorId(id);
        }

        public Cupon ObtenerCupoPorQR(string qr)
        {
            return ArticuloDB.SeleccionarCuponPorQR(qr);
        }

        public List<Articulo> ObtenerArticulosPorNegocioId(int id)
        {
            return ArticuloDB.ObtenerArticulosPorIDUsuario(id);
        }
    }
}
