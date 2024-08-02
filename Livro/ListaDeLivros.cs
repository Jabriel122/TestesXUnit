using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    public class ListaDeLivros
    {

        public string Genero {  get; set; }
        
        public static bool AdcicionarLivro(string Genero, string GeneroA)
        {
            if (Genero == GeneroA)
            {
                Console.WriteLine("Livro na Lista certa");
                return true;
            }
            else
            {
                Console.WriteLine("Livro na Lista errada");
                return false;
            }
        }

    }
}
