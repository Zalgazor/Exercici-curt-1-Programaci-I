using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string frase2;

            frase = "Hola soc l'Alex";

            Console.WriteLine("--------");
            Console.WriteLine("La frase");
            Console.WriteLine("--------");
            Console.WriteLine();

            Console.WriteLine(frase);
            Console.WriteLine();

            frase2 = "Hola";

            Console.WriteLine("--------------------");
            Console.WriteLine("posició paraula Hola");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.WriteLine(frase. IndexOf (frase2));

            Console.ReadKey();
        }
    }
}
