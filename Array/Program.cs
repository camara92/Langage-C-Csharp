using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {

            string[] tableau1 = { "Zoé", "Marc", "Daouda","Jean",  "Alexandre" }; 
            string [] tableau2 = new string[tableau1.Length];
            //on peut utiliser array.copy aussi 
            //Array.Copy(tableau2 , tableau1, tableau1.Length);
            Array.Clear(tableau2, 0, 2); 
            Console.WriteLine(tableau2.Length);
            //tableau1 = 2
            foreach(string tableau in tableau1)
            {
                Console.WriteLine(tableau);
            }
            Console.ReadLine();
        }

    }
}