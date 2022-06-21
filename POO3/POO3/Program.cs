using System;
namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal Chien1 = new Chien("britus", 2, 151525);
            Animal Poisson1 = new Poisson("Saumon de Bali", 5, true);
            Chien c1 = new Chien("Lolo", 2,141414 );
            Animal c2 = new Chien("Chevrebanboss", 15, 151614);
            c1.AfficheInfo();
            c2.AfficheInfo();
            //Chien1.AfficheInfo();
         
           // Poisson1.AfficheInfo();
            //Chien1.Parler();
           //Console.Read();

            //utilisation de la méthode 
        }
    }
}
