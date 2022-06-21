using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Chien :Animal
    {
        //attributs 
        public int NrTatouage;
        //constructeurs : de l'animal et ajout de la nouvelle attribut 
        public Chien(string nom, int age,int NrTatouage) :base (nom, age)
        {
            //il hérite les propriétés de la classe animale 
            this.NrTatouage = NrTatouage;
           // Console.WriteLine("Mon numéro de tatouage est le : " + NrTatouage);
        }
        //methodes 
        public void Parler()
        {
            Console.WriteLine("Wouf Wouf"); 
        }
        public void Marcher()
        {
            //Nom ici hérité de animal Class 

            //Console.WriteLine(Nom+" marche avec ses 4 pattes. ");
        }
        //un objet chien instancié mais un objet animal utilisé 
        //new par override : new tient pas compte 
        public virtual void AfficheInfo()
        {
            //base.AfficheInfo();
            Console.WriteLine("Je suis un chien, je me nomme " + Nom);
            Console.WriteLine("Moi c'est "+Nom + " et j'ai "+Age+ "an(s).");
        }


    }
}
