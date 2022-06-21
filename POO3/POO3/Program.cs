using System;
namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal monAnimal = new Animal("britus", 2);
            /*monAnimal.Nom = "Bengo";
            monAnimal.Age = 3;
            Console.WriteLine("Nom de l'animale est : " + monAnimal.Nom);
            Console.WriteLine("L'age de l"+ monAnimal.Nom + " est : " + monAnimal.Age);*/
            monAnimal.AfficheInfo(); 
            Console.ReadLine();

            //utilisation de la méthode 
        }
    }
}
