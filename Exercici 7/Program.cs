using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_7
{
    class Program
    {
        private static Random rnd = new Random(); // quan més important més a dalt de la classe
        static void Main(string[] args)
        {
            int[] array = llançarDau();

            foreach (int enter in array)
            {
                Console.Write(enter + " ");
                   
            }

            Console.ReadKey();
        }

        private static int[] llançarDau()
        {
            int[] array = new int[10];


            for (int i = 0; i < array.Length; i++)
            {
      
                array[i] = rnd.Next(1, 7);
            }

            return array;
        }

       
    }
}
