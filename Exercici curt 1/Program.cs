using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_curt_1
{
    class Program
    {
        private static string[] opcions = { "PEDRA", "PAPER", "TISORA" };
        private static string[,] resultats = {{"Empat", "Perds", "Guanyes"},{"Guanyes", "Empat", "Perds"},{"Perds", "Guanyes", "Empat"}};

        static void Main(string[] args)
        {

        }

        private static int opcioUsuari()
        {
            string eleccio;
            int eleccioNumero;

            Console.WriteLine("Selecciona una opció (1, 2 o 3):");

            for (int i = 1; i <= opcions.Length; i++)
            {
                Console.WriteLine($"{i}->{opcions[i-1]}");
            }

            eleccio = Console.ReadLine();
            int.TryParse(eleccio, out eleccioNumero);

            if (eleccioNumero == 1 || eleccioNumero == 2 || eleccioNumero == 3)
            {
                return eleccioNumero - 1;
            }
            else
            {
                return opcioUsuari();
            }

        }

        private static string comprovarQuiGuanya(int opcioUsuari, int opcioOrdinador)
        {
            Console.WriteLine($"         Usuari: {opcions[opcioUsuari]}");
            Console.WriteLine($"         Ordinador: {opcions[opcioOrdinador]}");
            Console.WriteLine("");
        }
    }
}
