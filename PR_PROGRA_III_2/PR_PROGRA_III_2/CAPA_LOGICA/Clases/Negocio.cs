using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que hereda de Usuario
    /// </summary>
    public class Negocio: Usuario
    {
        /// <summary>
        /// Propiedad que almacena la lista de articulos que pertenecen al negocio
        /// </summary>
        public List<Articulo> ListaProductos { get; set; }

        /// <summary>
        /// Propiedad que almacena la lista de calificaciones hechas por los clientes.
        /// </summary>
        public List<Calificacion> ListaCalificacion { get; set; }

        /// <summary>
        /// Propiedad que almacena el puntaje total del negocio
        /// </summary>
        public double PuntajeTotal { get; set; }

        /// <summary>
        /// Calcula el puntaje promedio del negocio
        /// </summary>
        /// <returns>Retorna el puntaje promedio del negocio</returns>
        public double CalificacionTotal()
        {
            int cont = 0;
            double puntaje = 0;
            foreach (Calificacion calificacion in ListaCalificacion)
            {
                puntaje += calificacion.puntaje;
                if (calificacion.puntaje > 0)
                    cont++;
            }
            return puntaje/cont;
        }
    }
}
