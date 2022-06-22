using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Operation: Iaddition1, ISoustraction
    {
        //les membres doivent être appelées 
        public int Nb1 { get; set ; }
        public int Nb2 { get; set; }
        public int Nb3 { get; set; }
       

        public void addition()
        {
            Console.WriteLine("La somme entre Nb1 et Nb2 est : " + (Nb1 + Nb2));
        }
        public void soustraction()
        {
            Console.WriteLine("La différence entre Nb1 et Nb2 est : "+(Nb1 - Nb2));
        }

    }
}
