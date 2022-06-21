using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    struct Personne
    {
        public string nom;
        public string prenom; 

        public Personne(string _nom, string _prenom) 
        { 
            nom = _nom;
            prenom = _prenom;
        }
        public void Parler()
        {
            Console.WriteLine(nom + " parle en langue Soninké.");
        }
    }
}
