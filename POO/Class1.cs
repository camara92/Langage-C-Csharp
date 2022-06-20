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
      //méthode 
      public void AfficheInfo()
        {
            Console.WriteLine("Je suis " + Nom);
            Console.WriteLine("J'ai " + Age + "an(s)");

        }
    }
}
