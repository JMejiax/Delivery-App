using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Facade
{
    /// <summary>
    /// Clase que contiene la definición del objeto pedido
    /// </summary>
    public class FacadePedido
    {
        /// <summary>
        /// Propiedad que almacena los productos seleccionados por el cliente en el pedido
        /// </summary>
        public List<Producto> ListaProductos = new List<Producto>();

        /// <summary>
        /// Propiedad que almacena el cupón canjeado por el cliente
        /// </summary>
        public Cupon _Cupon { get; set; }

        /// <summary>
        /// Propiedad que almacena el monto del impuesto
        /// </summary>
        private double Impuesto = 0.13d;

        /// <summary>
        /// Agrega un producto nuevo a la propiedad ListaProductos
        /// </summary>
        /// <param name="prod"></param>
        public void AgregarArticulo(Producto prod)
        {
            ListaProductos.Add(prod);
        }

        /// <summary>
        /// Asigna el valor de la propiedad _Cupon
        /// </summary>
        /// <param name="cupon"></param>
        public void AsignarCupon(Cupon cupon)
        {
            _Cupon = cupon;
        }

        /// <summary>
        /// Calcula el costo total de la productos seleccionados por el cliente
        /// </summary>
        /// <returns></returns>
        public double CostoSinCupones()
        {
            double totalCosto = 0;
            foreach (Producto prod in ListaProductos)
            {
                totalCosto += prod.Costo();
            }

            return totalCosto;
        }

        /// <summary>
        /// Calcula el monto de descuento del pedido
        /// </summary>
        /// <returns>retorna el valor del descuento del pedido</returns>
        public double DescuentoCupon()
        {
            double descuento = 0;
            if (_Cupon != null)
            {
                if (_Cupon is CupoDescuento)
                    descuento = (_Cupon as CupoDescuento).PorcentajeDescuento;
                if (_Cupon is CuponProductoGratis)
                {
                    foreach (Producto prod in ListaProductos)
                    {
                        if (prod.Id == (_Cupon as CuponProductoGratis).IDProducto)
                            return prod.Precio;
                        
                    }
                }
                    
            }
            else descuento = 0.0d;

            return descuento * CostoSinCupones();
        }

        /// <summary>
        /// Calcula el valor del impuesto del pedidod
        /// </summary>
        /// <returns>retorna el valor del impuesto del pedido</returns>
        public double ImpuestoVentas()
        {
            return CostoSinCupones() * Impuesto;
        }

        /// <summary>
        /// Devuelve el valor de la propiedad ListaProductos
        /// </summary>
        /// <returns>Retorna la propiedad ListaProductos</returns>
        public List<Producto> ObtenerPedido()
        {
            return ListaProductos;
        }
    }
}
