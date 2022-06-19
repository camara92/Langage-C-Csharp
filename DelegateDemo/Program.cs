using System;
namespace DelegateDemo
{
    class Program
    {
        delegate void MyDelegate(int nb1, int nb2);
        static void Main(string[] args)
        {
            //   Console.WriteLine("Daouda");
            MyDelegate operation = addition;
            operation(10, 25);
         Console.Read();

            //
            operation = soustraction; 

            operation(10, 25);
            Console.Read();
            //methode 
            void addition (int nb1, int nb2)
            {
                Console.WriteLine(nb1+nb2);
            }
            void soustraction(int nb1, int nb2)
            {
                Console.WriteLine(nb1 -nb2);
            }
        }

        
    }

}
