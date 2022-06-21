using System;

namespace POO4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne pers = new Personne();
            //on peut ne pas instancier avec new Personne
            Personne pers; 
            pers.nom = "CAMARA ";
            pers.prenom = "Daouda";
            pers.Parler(); 

            Console.ReadLine(); 
        }
    }
}