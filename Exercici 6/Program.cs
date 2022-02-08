using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "9, 6";
            String[] coord = input.Split(',');

            String fila = coord[0];
            String columna = coord[1];

            Console.Write($"hola {fila} i {columna}");

            Console.ReadKey();


        }

        
    }
}
