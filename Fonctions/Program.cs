using System;
namespace Fonctions
{
    class Program
    {
        static void Main()
        {
            int Somme(int nb1, int nb2)
            {
                return nb1 + nb2;
            }
            int s = Somme(10, 15);
            Console.WriteLine(s);
            Console.Read();
        }
    }
}