using System;
//importer IO
using System.IO;

namespace Persistance_des_donnees
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            using(StreamWriter sw =new StreamWriter("d:\\data\\test.txt"))
            {   //ajout du text dans fichier txt 
                sw.WriteLine("1ère ligne");
            }
            using (StreamWriter sw = File.AppendText("d:\\data\\test.txt"))
            {
                //Chaque exécution sera ajouté au fichier 
                sw.WriteLine("Bonjour est ajouté ");
            }

           using (StreamReader sr= new StreamReader("d:\\data\\test.txt"))
            {
                string line = null;
                line = sr.ReadLine(); 
                while(line!= null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
          
           using (StreamReader sr= new StreamReader("d:\\data\\test.txt"))
            {   //lire tout 
                string file = sr.ReadToEnd();
                Console.WriteLine(file);
            }
            Console.ReadLine(); 
        }
    }
}
