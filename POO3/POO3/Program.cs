using System;
namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal Chien1 = new Chien("britus", 2, 151525);
            Animal Poisson1 = new Poisson("Saumon de Bali", 5, true);
          

            Chien1.AfficheInfo();
         
            Poisson1.AfficheInfo();
            //Chien1.Parler();
            Console.ReadLine();

            //utilisation de la méthode 
        }
    }
}
