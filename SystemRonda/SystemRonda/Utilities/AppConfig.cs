using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SystemRonda.Utilities
{
   public static class AppConfig
    {
        /// <summary>
        /// Cadena de conexion a base de datos
        /// </summary>
        public static string connection = ConfigurationManager.ConnectionStrings["connection"].ToString();

        /// <summary>
        /// codigo del producto
        /// </summary>
        public static string codeProd = string.Empty;


    }
}
