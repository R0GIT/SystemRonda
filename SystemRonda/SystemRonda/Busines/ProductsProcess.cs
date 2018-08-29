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
        /// <summary>
        /// Obtiene el listado de productos
        /// </summary>
        /// <param name="idPlanta"></param>
        /// <param name="productsList"></param>
        /// <returns></returns>
        public static bool GetProductsLits(int idPlanta,ref List<ProductList> productsList)
        {
            return DataAcess.ProductConnection.GetProductLits(idPlanta,ref productsList);
        }

        /// <summary>
        /// obtiene el producto indicado por codigo de producto
        /// </summary>
        /// <param name="codeProduct"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public static bool GetProduct(string codeProduct, ref Product product)
        {
            return DataAcess.ProductConnection.GetProduct(codeProduct, ref product);
        }

        /// <summary>
        /// actualiza el producto indicado por el producto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static bool UpdatesProduct(Product product)
        {

            return DataAcess.ProductConnection.UpdatesProduct(product);
        }

        /// <summary>
        /// Inserta el producto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static bool InsertProduct(Product product)
        {

            return DataAcess.ProductConnection.InsertProduct(product);
        }

    }
}
