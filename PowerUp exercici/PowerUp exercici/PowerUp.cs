using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUp_exercici
{
    class PowerUp
    {
        public string Nom;
        public int id;
        public readonly DateTime initialPersonalTime;

        public static int Count;
        public const int MAX_TIME = 700;

        public PowerUp()
        {
            Count++;
            id = Count; 
            initialPersonalTime = DateTime.Now;
                     
        }
        public PowerUp(string Nom) : this()// this() crida el constructor per defecte (intentem evitar codi duplicat)
        {
            this.Nom = Nom;
        }


    }
}
