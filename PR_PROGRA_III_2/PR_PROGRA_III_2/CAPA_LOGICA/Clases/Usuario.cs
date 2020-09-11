using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Clases
{
    /// <summary>
    /// Clase que contiene la definición de un Usuario
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Propieda que almacena el ID del usuario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propieda que almacena la cédula del usuario
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// Propieda que almacena el nombre del usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propieda que almacena el número de telefono del usuario
        /// </summary>
        public string NumeroTelefono { get; set; }

        /// <summary>
        /// Propieda que almacena la dirección del usuario
        /// </summary>
        public Direccion _Direccion { get; set; }

        /// <summary>
        /// Propieda que almacena el correo electronico del usuario
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Propieda que almacena la contraseña del usuario
        /// </summary>
        public string Contrasenna { get; set; }

        /// <summary>
        /// Propieda que almacena la tarjeta del usuario
        /// </summary>
        public Tarjeta _Tarjeta { get; set; }

        /// <summary>
        /// Propieda que almacena el estado del usuario
        /// </summary>
        public bool Activo { get; set; }

    }
}
