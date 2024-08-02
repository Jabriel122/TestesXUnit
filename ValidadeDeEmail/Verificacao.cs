using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadeDeEmail
{
    public class Verificacao
    {

        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Email Verificado com sucesso");
                return true;
            }
            return false;
        }
    }
}
