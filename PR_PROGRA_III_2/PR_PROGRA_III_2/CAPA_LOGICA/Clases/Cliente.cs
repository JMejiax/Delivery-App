using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase heredada de usuario
    /// </summary>
    public class Cliente: Usuario
    {
        // Propiedad que almacena los apellidos del cliente
        public string Apellidos { get; set; }
    }
}
