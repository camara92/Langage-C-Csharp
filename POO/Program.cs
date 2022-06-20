using System;

namespace POO
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            Animal monAnimal = new Animal();
            monAnimal.Age = 2;
            monAnimal.Nom = "Chat"; 

            Console.WriteLine(monAnimal.Nom);
            Console.WriteLine(monAnimal.Age);

            Animal monAnimal2 = new Animal();
            monAnimal2.Age = 20;
            monAnimal.Nom = "Chien";

            monAnimal.AfficheInfo(); 

            Console.ReadLine();

        }
    }
}