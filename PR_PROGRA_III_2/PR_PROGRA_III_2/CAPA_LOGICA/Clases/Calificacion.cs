using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que almacena las calificaciones que el cliente le de a los negocios y repartidores
    /// </summary>
    public class Calificacion
    {
        /// <summary>
        /// Propiedad que almacena el puntaje dado por el cliente
        /// </summary>
        public double puntaje { get; set; }
        /// <summary>
        /// Propiedad que almacena el comentario dado por el cliente
        /// </summary>
        public string comentario { get; set; }
    }
}
