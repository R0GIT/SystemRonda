using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemRonda.Models;

namespace SystemRonda.DataAcess
{
   public class ProductConnection
    {
        /// <summary>
        /// obtiene el listado de productos por planta
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool GetProductLits(int idPlanta, ref List<ProductList> productsList)
        {
            bool exist = false;
            List<SqlParameter> parameterList = new List<SqlParameter>();
            string storeName = "uspGetProducts";

            try
            {
                using (SqlConnection connection = new SqlConnection(Utilities.AppConfig.connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(storeName, connection);
                    SqlDataReader reader = null;

                    command.CommandType = CommandType.StoredProcedure;

                    parameterList.Add(new SqlParameter("@idPlanta", idPlanta));
                    

                    command.CommandTimeout = 15000;

                    command.Parameters.AddRange(parameterList.ToArray());

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ProductList product = new ProductList();
                            product.codigoProducto = reader["codigoProducto"].ToString();
                            product.idTipoProducto = reader.GetInt32(1);
                            product.descripcionCompleta = reader.GetString(2);
                            product.status = Convert.ToInt32(reader["status"]);

                            productsList.Add(product);
                        }
                        exist = true;
                    }
                    else
                    {
                        exist = false;
                    }

                    connection.Close();
                    connection.Dispose();
                    command.Dispose();
                }

            }
            catch (Exception ex)
            {
                exist = false;
            }
            finally
            {
                GC.Collect();
            }
            return exist;
        }

        /// <summary>
        /// obtiene los datos del producto
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool GetProduct(string codigoProducto, ref Product product)
        {
            bool exist = false;
            List<SqlParameter> parameterList = new List<SqlParameter>();
            string storeName = "uspGetProduct";

            try
            {
                using (SqlConnection connection = new SqlConnection(Utilities.AppConfig.connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(storeName, connection);
                    SqlDataReader reader = null;

                    command.CommandType = CommandType.StoredProcedure;

                    parameterList.Add(new SqlParameter("@productCode", codigoProducto));

                    command.CommandTimeout = 15000;

                    command.Parameters.AddRange(parameterList.ToArray());

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            product.idPlanta = Convert.ToInt32(reader["idPlanta"]);
                            product.idTipoProducto = Convert.ToInt32(reader["idTipoProducto"]);
                            product.divicion = Convert.ToChar(reader["divicion"]);
                            product.codigoProducto = reader["codigoProducto"].ToString();
                            product.espesor = Convert.ToDouble(reader["espesor"]);
                            product.anchor = Convert.ToDouble(reader["anchor"]);
                            product.largo = Convert.ToDouble(reader["largo"]);
                            product.unidadMedida = Convert.ToInt32(reader["unidadMedida"]);
                            product.pesoTeorico = Convert.ToDouble(reader["pesoTeorico"]);
                            product.unidadMedidaVenta = Convert.ToInt32(reader["unidadMedidaVenta"]);
                            product.descripcionCompletaProducto = Convert.ToString(reader["descripcionCompletaProducto"]);
                            product.descripcionAbreviadaProducto = Convert.ToString(reader["descripcionAbreviadaProducto"]);
                            product.piezasProducto = Convert.ToInt32(reader["piezasProducto"]);
                            product.cajasPorTarima = Convert.ToInt32(reader["cajasPorTarima"]);

                        }
                        exist = true;
                    }
                    else
                    {
                        exist = false;
                    }

                    connection.Close();
                    connection.Dispose();
                    command.Dispose();
                }

            }
            catch (Exception ex)
            {
                exist = false;
            }
            finally
            {
                GC.Collect();
            }
            return exist;
        }

        /// <summary>
        /// Actualiza el producto
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool UpdatesProduct(Product product)
        {
            bool exist = false;
            List<SqlParameter> parameterList = new List<SqlParameter>();
            string storeName = "uspModifyProduct";
            int resultado = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(Utilities.AppConfig.connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(storeName, connection);

                    command.CommandType = CommandType.StoredProcedure;
                    parameterList.Add(new SqlParameter("@idPlanta", product.idPlanta));
                    parameterList.Add(new SqlParameter("@idTipoProducto", product.idTipoProducto));
                    parameterList.Add(new SqlParameter("@divicion", product.divicion));
                    parameterList.Add(new SqlParameter("@codigoProducto", product.codigoProducto));
                    parameterList.Add(new SqlParameter("@espesor", product.espesor));
                    parameterList.Add(new SqlParameter("@anchor", product.anchor));
                    parameterList.Add(new SqlParameter("@largo", product.largo));
                    parameterList.Add(new SqlParameter("@unidadMedida", product.unidadMedida));
                    parameterList.Add(new SqlParameter("@pesoTeorico", product.pesoTeorico));
                    parameterList.Add(new SqlParameter("@unidadMedidaVenta", product.unidadMedidaVenta));
                    parameterList.Add(new SqlParameter("@descripcionCompletaProducto", product.descripcionCompletaProducto));
                    parameterList.Add(new SqlParameter("@descripcionAbreviadaProducto", product.descripcionAbreviadaProducto));
                    parameterList.Add(new SqlParameter("@piezasProducto", product.piezasProducto));
                    parameterList.Add(new SqlParameter("@cajasPorTarima", product.cajasPorTarima));

                    command.CommandTimeout = 15000;
                    command.Parameters.AddRange(parameterList.ToArray());
                    resultado = command.ExecuteNonQuery();

                    if (resultado != 0)
                    {       
                        exist = true;
                    }
                    else
                    {
                        exist = false;
                    }

                    connection.Close();
                    connection.Dispose();
                    command.Dispose();
                }

            }
            catch (Exception ex)
            {
                exist = false;
            }
            finally
            {
                GC.Collect();
            }
            return exist;
        }

        /// <summary>
        /// Inserta el producto
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool InsertProduct(Product product)
        {
            bool exist = false;
            List<SqlParameter> parameterList = new List<SqlParameter>();
            string storeName = "uspRegisterProduct";
            int resultado = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(Utilities.AppConfig.connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(storeName, connection);

                    command.CommandType = CommandType.StoredProcedure;
                    parameterList.Add(new SqlParameter("@idPlanta", product.idPlanta));
                    parameterList.Add(new SqlParameter("@idTipoProducto", product.idTipoProducto));
                    parameterList.Add(new SqlParameter("@divicion", product.divicion));
                    parameterList.Add(new SqlParameter("@codigoProducto", product.codigoProducto));
                    parameterList.Add(new SqlParameter("@espesor", product.espesor));
                    parameterList.Add(new SqlParameter("@anchor", product.anchor));
                    parameterList.Add(new SqlParameter("@largo", product.largo));
                    parameterList.Add(new SqlParameter("@unidadMedida", product.unidadMedida));
                    parameterList.Add(new SqlParameter("@pesoTeorico", product.pesoTeorico));
                    parameterList.Add(new SqlParameter("@unidadMedidaVenta", product.unidadMedidaVenta));
                    parameterList.Add(new SqlParameter("@descripcionCompletaProducto", product.descripcionCompletaProducto));
                    parameterList.Add(new SqlParameter("@descripcionAbreviadaProducto", product.descripcionAbreviadaProducto));
                    parameterList.Add(new SqlParameter("@piezasProducto", product.piezasProducto));
                    parameterList.Add(new SqlParameter("@cajasPorTarima", product.cajasPorTarima));

                    command.CommandTimeout = 15000;
                    command.Parameters.AddRange(parameterList.ToArray());
                    resultado = command.ExecuteNonQuery();

                    if (resultado != 0)
                    {
                        exist = true;
                    }
                    else
                    {
                        exist = false;
                    }

                    connection.Close();
                    connection.Dispose();
                    command.Dispose();
                }

            }
            catch (Exception ex)
            {
                exist = false;
            }
            finally
            {
                GC.Collect();
            }
            return exist;
        }


    }
}
