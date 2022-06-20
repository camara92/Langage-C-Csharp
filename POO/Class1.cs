using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Animal
    {   //si on ne spécfie rien il est en private 
        public string Nom;
        public int Age;
        //Constructeur par défaut 
        public Animal()
        {
            Console.WriteLine("Exécution du constructeur par défaut. ");
        }
        public Animal(string Nom, int Age)
        {
            this.Nom = Nom;
            this.Age = Age;
        }
    

        //méthode 
        public void AfficheInfo()

        {   
            //constructeurs d'objets 
            Animal chien = new Animal(); 

            //fin construct 
            Console.WriteLine("Je suis " + Nom);
            Console.WriteLine("J'ai " + Age + "an(s)");

        }
    }
}
