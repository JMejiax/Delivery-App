﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    class Conexion
    {
        public static string Cadena
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                    ["Capa.UI.Properties.Settings.Cadena"].
                    ConnectionString;
            }
        }
    }
}