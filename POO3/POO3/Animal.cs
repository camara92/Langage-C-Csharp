using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Animal
    {
        //les attributs 
        public string Nom;
        public int Age;

        //constructeur par défaut 
        public Animal()
        {
           // Console.WriteLine("J'ai ");
           //intérêt de faire passer les infos des attributs 
           //en le supprimant on ne peut passer d'autres infos sans qu'il y ait des infos sur ce dernier 
           //ne s'exécutant qu'au moment de l'instanciation 

        }

        public Animal(string Nom, int Age)
        {
            this.Nom = Nom;
            this.Age = Age;
        }
       


        //méthodes 
        public void AfficheInfo()
        {
            Console.WriteLine("Je suis "+Nom);
            Console.WriteLine("J'ai " + Age); 
        }
    }
}
