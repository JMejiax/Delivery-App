using CAPA_ENTIDADES.Clases;
using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPA_LN
{
    public class DireccionLN
    {
        public void InsertarDireccion(Direccion direccion)
        {
            DireccionDB.Insertar(direccion);
        }
        public void ActualizarDireccion(Direccion direccion)
        {
            DireccionDB.Actualizar(direccion);
        }
    }
}
