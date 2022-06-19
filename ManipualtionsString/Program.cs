using System; 
namespace ManipulationString
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "   Le C# c'est top.   ";
            string mystring2 = "convertir moi en majuscul Le";
            mystring2 = mystring2.ToUpper();
            //supprimer les espaces 
            //trim 
            //tolower : mettre en minuscule 
            //mystring = mystring.ToLower();
           // mystring = mystring.Trim();
            //replacer un caractere 
            //mystring = mystring.Replace("C", "Le langage C");
           // mystring = mystring.Remove(0,1);
            Console.WriteLine(mystring);
            Console.WriteLine(mystring2);
            //verifier si un elm est present ou pas

            //substring : extraire 
            mystring = mystring.Substring(2); 
            //mystring.indexOf()
            //LastIndexOf : le dernier 

            Console.WriteLine(mystring2.Contains("Le"));
            Console.WriteLine();
            Console.Write("nombre caractères "+ mystring2.Length);

            Console.ReadLine(); 
        }
    }

}
