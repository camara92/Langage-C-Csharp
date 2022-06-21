using System; 
namespace POO_GETTER_SETTER
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            Animal ani1 = new Animal("REX", 4);
            ani1.Nom = "Bridouille";
            Console.WriteLine(ani1.Nom); 

            Console.WriteLine(ani1);
            ani1.Age = 0; 
            Console.WriteLine(ani1.Age);

            
        Console.Read();
        }
    }
}