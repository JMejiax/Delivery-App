using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Factory
{
    /// <summary>
    /// Clase cuya función es contruir el objeto Transporte
    /// </summary>
    public class FactoryTransporte
    {
        /// <summary>
        /// Propiedad que almacena el objeto Transporte
        /// </summary>
        Transporte _Transporte  = null;

        /// <summary>
        /// Crea la instancia al Transporte dependiendo del tipo de transporte
        /// </summary>
        /// <param name="tp">Enum tipo transporte</param>
        /// <returns>Objeto tipo Transporte</returns>
        public Transporte CrearTransporte(TipoTransporte tp)
        {
            if (tp == TipoTransporte.Bicicleta) _Transporte = new Bicicleta();
            if (tp == TipoTransporte.Motocicleta) _Transporte = new Motocicleta();
            if (tp == TipoTransporte.Automovil) _Transporte = new Automovil();

            return _Transporte;
        }
    }
}
