using System;

namespace Environnement_classe
{
    class PROGRAM
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.TickCount); //depuis le démarrage du système exploitation 
            Console.ReadLine();
        }
    }
}