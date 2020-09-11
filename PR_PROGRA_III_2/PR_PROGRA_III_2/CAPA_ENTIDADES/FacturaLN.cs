using CAPA_DATOS;
using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LN
{
    public class FacturaLN
    {
        public void IngresarFactura(Factura _Factura)
        {
            FacturaDB.Insertar(_Factura);
        }

        public void RelacionarNegocio(Factura _Factura, double puntaje, string comentario)
        {
            FacturaDB.RelacionarNegocio(_Factura, puntaje, comentario);
        }
        public void RelacionarRepartidor(Factura _Factura, double puntaje, string comentario)
        {
            FacturaDB.RelacionarRepartidor(_Factura, puntaje, comentario);
        }


        public void RelacionarCliente(Factura _Factura)
        {
            FacturaDB.RelacionarCliente(_Factura);
        }

        public void InsertarCuponUsado(Cliente cliente, Cupon cupon)
        {
            FacturaDB.InsertarCuponUsado(cliente, cupon);
        }

        public List<Factura> SeleccionarFacturaPorNegocioID(int id)
        {
            return FacturaDB.SeleccionarFacturaPorNegocioID(id);
        }

        public void CambiarEstadoFactura(int id, string estado)
        {
            FacturaDB.CambiarEstado(id, estado);
        }

        public List<Factura> ObtenerFacturasListas()
        {
            return FacturaDB.ObtenerFacturasListas();
        }

        public Factura ObtenerFacturaSinCalificar(int idCliente)
        {
            return FacturaDB.ObtenerFacturaSinCalificar(idCliente);
        }

        public void ActualizarRelacionNegocio(Factura _Factura, double puntaje, string comentario)
        {
            FacturaDB.ActualizarRelacionNegocio(_Factura, puntaje, comentario);
        }
        
        public void ActualizarRelacionRepartidor(Factura _Factura, double puntaje, string comentario)
        {
            FacturaDB.ActualizarRelacionRepartidor(_Factura, puntaje, comentario);
        }
        public void CambiarEstadoCalificacion(int id, string estado)
        {
            FacturaDB.CambiarEstadoCalificacion(id, estado);
        }

    }
}
