using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Poisson : Animal
    {
        //attributs 
        public bool eauFroide;
        //constructeurs : de l'animal et ajout de la nouvelle attribut 
        public Poisson(string nom, int age, bool eauFroide) : base(nom, age)
        {
            //il hérite les propriétés de la classe animale 
            this.eauFroide = eauFroide;
           // Console.WriteLine("Je vis dans des zones appelées : " + eauFroide);
        }
        //methodes 
        public void Parler()
        {
            Console.WriteLine("DE l'eau😂");
        }
        public void Nager()
        {
            //Nom ici hérité de animal Class 

            Console.WriteLine(Nom + " Je nage. ");
        }


    }
}

