using CAPA_ENTIDADES.Clases;
using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LN
{
    public class TarjetaLN
    {
        public void InsertarTarjeta(Tarjeta tarjeta)
        {
            TarjetaDB.Insertar(tarjeta);
        }

        public void ActualizarTarjeta(Tarjeta tarjeta)
        {
            TarjetaDB.Actualizar(tarjeta);
        }
    }
}
