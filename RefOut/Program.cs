using System;
namespace REfOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenom = "jean";
            MethodeVal(prenom);

            Console.WriteLine("MethodVAl " + prenom);
            //
            string prenom2 = "jean";
            MethodeParRef(ref prenom2);

            Console.WriteLine("MethodRef " + prenom2);
            Console.ReadLine(); 
            Console.WriteLine();
            void MethodeVal(string str)
            {
                str = "Toto";
            }
            void MethodeParRef( ref string str)
            {
                str = "Toto"; 
            }
        }
    }
}