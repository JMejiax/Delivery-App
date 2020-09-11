using CAPA_LOGICA.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA.Interfaces
{
    public interface IExpress
    {
        Usuario _Negocio { get; set; }
        Usuario _Cliente { get; set; }

        float CalcularExpress();
    }
}
