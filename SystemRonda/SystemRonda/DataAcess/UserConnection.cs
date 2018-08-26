using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SystemRonda.DataAcess
{
   public class UserConnection
    {
        /// <summary>
        /// obtiene los dtos del usuario
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool getUser(string userName,string password)
        {
            bool exist = false;
            List<SqlParameter> parameterList = new List<SqlParameter>();
            string storeName = "usp_Login";

            try
            {
                using (SqlConnection connection = new SqlConnection(Utilities.AppConfig.connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(storeName, connection);
                    SqlDataReader reader = null;

                    command.CommandType = CommandType.StoredProcedure;

                    parameterList.Add(new SqlParameter("@usuario", userName));
                    parameterList.Add(new SqlParameter("@contrasenia", userName));

                    command.CommandTimeout = 15000;

                    command.Parameters.AddRange(parameterList.ToArray());

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
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
