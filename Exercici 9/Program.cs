using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] arrayInt = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.Write("Escriu el numero que vols buscar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"numero {numero} es troba ? {Program.buscar(arrayInt, numero)}");

            Console.ReadKey();
        }

        private static bool buscar(int[] enters, int enterBuscat)
        {
            bool trobat = false;
            // recorre l’array fins trobar l’element trobat
            for (int i = 0; i < enters.Length; i++)
            {
                if (enters[i] == enterBuscat)
                {
                    trobat = true;
                }
            }
            return trobat;
        }

    }
}
