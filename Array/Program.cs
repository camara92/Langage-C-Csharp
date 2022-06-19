using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)

        {

            string[] tableau1 = { "Zoé", "Marc", "Daouda","Jean",  "Alexandre" }; 
            string [] tableau2 = new string[tableau1.Length];
            //on peut utiliser array.copy aussi 
         //rray.Copy(tableau2 , tableau1, tableau1.Length);
           //rray.Resize(ref tableau2, 10);
            Console.WriteLine("Index de Daouda " + Array.IndexOf(tableau1, "Daouda")); 
            //Array.Clear(tableau2, 0, 2); 
            //array.short(tableau2); 

            //Console.WriteLine(tableau2.Length);

            //tableau1 = 2
           /* foreach(string tableau in tableau1)
            {
                Console.WriteLine(tableau);
            }*/

            //array.reverse 

            Console.ReadLine();
        }

    }
}