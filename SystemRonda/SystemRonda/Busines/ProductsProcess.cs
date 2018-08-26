using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemRonda.Models;

namespace SystemRonda.Busines
{
   public class ProductsProcess
    {
        public static bool GetProductsLits(int idPlanta,ref List<ProductList> productsList)
        {
            return DataAcess.ProductConnection.GetProductLits(idPlanta,ref productsList);
        }

        public static bool UpdatesProduct(Product product)
        {

            return DataAcess.ProductConnection.UpdatesProduct(product);
        }

    }
}
