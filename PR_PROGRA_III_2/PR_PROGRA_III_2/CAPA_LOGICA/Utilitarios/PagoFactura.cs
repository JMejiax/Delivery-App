using CAPA_ENTIDADES.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Utilitarios
{
    public class PagoFactura
    {

        /// <summary>
        /// Valida si una tarjeta es válidad
        /// </summary>
        /// <param name="tarjeta">El número de la tarjeta</param>
        /// <returns>Retorna true si la tarjeta es válida</returns>
        public static bool ValidarTarjeta(string tarjeta)
        {
            {
                int s1 = 0, s2 = 0;
                String reversa = tarjeta.Reverse<char>().ToString();

                for (int i = 0; i < tarjeta.Length; i++)
                {
                    int digito = Convert.ToInt32(tarjeta.Substring(tarjeta.Length - 1 - i, 1));
                    if (i % 2 == 0)
                    {
                        s1 += digito;
                    }
                    else
                    {
                        s2 += 2 * digito;
                        if (digito >= 5)
                        {
                            s2 -= 9;
                        }
                    }
                }
                if ((s1 + s2) % 10 == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
