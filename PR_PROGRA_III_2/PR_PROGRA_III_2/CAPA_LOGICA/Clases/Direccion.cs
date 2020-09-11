using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que contiene la definicion del objeto Dirección
    /// </summary>
    public class Direccion
    {
        /// <summary>
        /// Porpiedad que almacena el ID de la dirección
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Porpiedad que almacena la latitud de la dirección
        /// </summary>
        public string latitud { get; set; }

        /// <summary>
        /// Porpiedad que almacena la longitud de la dirección
        /// </summary>
        public string longitud { get; set; }

        /// <summary>
        /// Porpiedad que almacena la descripción de la dirección
        /// </summary>
        public string Descripcion { get; set; }
    }
}
