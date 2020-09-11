using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Utilitarios
{
    public class Express
    {
        // GMaps API KEY = AIzaSyCNF0mD-Lk0Dtal7CoFJ_9H4q1jTp3XcqY
        /// <summary>
        /// Calcula la cantidad de kilometros entre dos puntos usando el api de google maps
        /// </summary>
        /// <param name="longitud1">Longitud del primer punto</param>
        /// <param name="latitud1">Latitud del primer punto</param>
        /// <param name="longitud2">Longitud del segundo punto</param>
        /// <param name="latitud2">Latitud del segundo punto</param>
        public static double calcularDistancia2(double longitud1, double latitud1, double longitud2, double latitud2)
        {
            List<PointLatLng> Points = new List<PointLatLng>();
            PointLatLng Negocio = new PointLatLng(latitud2, longitud2);
            PointLatLng Cliente = new PointLatLng(latitud1, longitud1);
            Points.Add(Negocio);
            Points.Add(Cliente);
            return new MapRoute(Points, "").Distance;
        }


    }
}
