using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.Login
{
    public class LoginClass
    {
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool AuthMethodTest(string login, string password)
        {
            Core db = new Core();
            
          
                int countRecord = db.context.login
                .Where(x => x.login1 == login && x.password == password)
                .Count();
                if (countRecord == 1)
                {
                
                    return true;      
                }
                return false;
        }
    }
}
