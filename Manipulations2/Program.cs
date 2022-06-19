using System; 
namespace Manipulation
{
    class ManipulationString
    {
        static void Main()
        {
            string str = "Jan, Delphi, pascal, Cams, laboulette";
            string[] tabstr = str.Split(", "); 
            foreach(string tab in tabstr)
            {
                Console.WriteLine(tab);
            }

            //Console.WriteLine(tabstr);
            string str2 = string.Join("| ", tabstr);
            Console.WriteLine(str2);    

            Console.ReadLine(); 
        }
    }
}
