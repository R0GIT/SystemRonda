using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRonda.Models
{
   public class Product
    {
        public int idPlanta { get; set; }
        public string codigoProducto { get; set; }
        public int idTipoProducto { get; set; }
        public string descripcionCompleta { get; set; }
        public char divicion { get; set; }
        public double espesor { get; set; }
        public double anchor { get; set; }
        public double largo { get; set; }
        public int unidadMedida { get; set; }
        public double pesoTeorico { get; set; }
        public int unidadMedidaVenta { get; set; }
        public string descripcionCompletaProducto { get; set; }
        public string descripcionAbreviadaProducto { get; set; }
        public int piezasProducto { get; set; }
        public int cajasPorTarima { get; set; }
        public int status { get; set; }

    }
}
