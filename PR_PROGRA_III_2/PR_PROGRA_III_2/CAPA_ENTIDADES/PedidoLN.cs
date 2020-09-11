using CAPA_DATOS;
using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LN
{
    public class PedidoLN
    {
        public void InsertarDetalleFactura(Producto prod)
        {
            PedidoDB.Insertar(prod);
        }
    }
}
