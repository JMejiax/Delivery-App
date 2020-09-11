using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Utilitarios
{
    public class Moneda
    {
        /// <summary>
        /// Convierte un monto en colones a dólares
        /// </summary>
        /// <param name="Monto">El monto a convertir</param>
        /// <returns>Retorna el monto en dólares</returns>
        public static double ConversionDolares(double Monto)
        {
            cr.fi.bccr.gee.wsindicadoreseconomicos cliente = new cr.fi.bccr.gee.wsindicadoreseconomicos();
            DataSet TipoCambio = cliente.ObtenerIndicadoresEconomicos("317", "05/08/2020", "05/08/2020", "Jonathan Mejias", "N", "jmejias986@gmail.com", "9A2G9MT0MT");

            double TipoCambioDolar = Convert.ToDouble(TipoCambio.Tables[0].Rows[0].ItemArray[2]);

            return Convert.ToDouble((Monto/TipoCambioDolar).ToString("0.##"));
        }

        
    }
}
