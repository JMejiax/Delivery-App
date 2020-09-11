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
    public class Repartidor: Usuario
    {
        /// <summary>
        /// Propiedad que almacena los apellidos del repartidor
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Propiedad que almacena el transporte que pertenece al repartidor
        /// </summary>
        public Transporte _Transporte { get; set; }

        /// <summary>
        /// Propiedad que almacena el puntaje total del repartidor
        /// </summary>
        public double PuntajeTotal { get; set; }

        /// <summary>
        /// Propiedad que almacena la lista de calificaciones hechas por los clientes.
        /// </summary>
        public List<Calificacion> ListaCalificacion { get; set; }

        /// <summary>
        /// Calcula el puntaje promedio del repartidor
        /// </summary>
        /// <returns>Retorna el puntaje promedio del repartidor</returns>
        public double CalificacionTotal()
        {
            int cont = 0;
            double calificacionTotal = 0.0d;
            foreach(Calificacion ca in ListaCalificacion)
            {
                calificacionTotal += ca.puntaje;
                if (ca.puntaje > 0)
                    cont++;
            }
            return calificacionTotal / cont;
        }
    }
}
