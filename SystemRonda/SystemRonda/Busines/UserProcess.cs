using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRonda.Busines
{
   public class UserProcess
    {
        /// <summary>
        /// realiza el proceso de logueo de los usuarios
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool userLogin(string userName,string password)
        {
            return DataAcess.UserConnection.getUser(userName, password);

        }
    }
}
