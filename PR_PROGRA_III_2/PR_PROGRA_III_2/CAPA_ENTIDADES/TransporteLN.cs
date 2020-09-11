using CAPA_ENTIDADES.Clases;
using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LN
{
    public class TransporteLN
    {
        #region INSERTAR
        public void IngresarBicicleta(Bicicleta bici)
        {
            TransporteDB.IngresarBicicleta(bici);
        }

        public void IngresarAuto(Automovil auto)
        {
            TransporteDB.IngresarAuto(auto);
        }

        public void IngresarMoto(Motocicleta moto)
        {
            TransporteDB.IngresarMoto(moto);
        }

        #endregion INSERTAR

        #region ACTUALIZAR

        public void ActualizarBicicleta(Bicicleta bici)
        {
            TransporteDB.ActualizarBicicleta(bici);
        }

        public void ActualizarAuto(Automovil auto)
        {
            TransporteDB.ActualizarAuto(auto);
        }

        public void ActualizarMoto(Motocicleta moto)
        {
            TransporteDB.ActualizarMoto(moto);
        }


        #endregion ACTUALIZAR

        public void EliminarTransporte(int id)
        {
            TransporteDB.Eliminar(id);
        }
    }
}
