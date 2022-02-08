using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[] { 1, 2, 3, 4, 5, 6 };
            int sumaArray = Program.Suma(arrayInt);

            Console.WriteLine($"Suma: {sumaArray}");

            Console.ReadKey();

        }

        private static int Suma(int[] enters)
        {
            int suma = 0;
            // recorre tota l’array per suma tots els elements
            for (int i = 0; i < enters.Length; i++)
            {
                suma = suma + enters[i]; // igual que suma += enters[index];
            }
            return suma;
        }
    }
}
