using System;
namespace DateHeure
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
             DateTime maintenant = DateTime.Now;
             Console.WriteLine(maintenant.Day);
             Console.WriteLine(maintenant.Month);
             Console.WriteLine(maintenant.Year);
             Console.WriteLine(maintenant.Hour);
             Console.WriteLine(maintenant.Second);
             Console.WriteLine(maintenant.Minute);
             Console.WriteLine(maintenant.Minute);
             Console.WriteLine(maintenant);
             //créer des intervalles de temps 
             TimeSpan heureDujour = maintenant.TimeOfDay;
             Console.WriteLine("Heure actuelle " + heureDujour);

             TimeSpan interval = new TimeSpan(0, 10, 0);
             Console.WriteLine("Heure +10min " + heureDujour.Add(interval));
             Console.WriteLine("Heure -10min " + heureDujour.Subtract(interval));

             DateTime NouvelleDate = maintenant.AddMonths(2); 
             Console.WriteLine("Date +2 mois "+NouvelleDate);
             Console.WriteLine("Daouda");
             DateTime NouvelleDate1 = maintenant.AddMonths(-2);
             Console.WriteLine("Date -2 mois " + NouvelleDate1);

            */
            DateTime maintenant = DateTime.Now; 
            DateTime dnaissance = new DateTime(1992, 12, 31); 
            TimeSpan result = maintenant.Subtract(dnaissance);

            Console.WriteLine("Resultat est : "+ result);
            Console.WriteLine("nb jour "+result.Days);
            Console.WriteLine("nb heure " + result.Hours);
            Console.WriteLine("nb minute " + result.Seconds);
            Console.WriteLine("Nombre de période écoulant depuis votre ,naissance est : "+ result.Days+ "jours, "  + result.Hours + " heure " + ", " + result.Minutes+" minutes et "+ result.Seconds+ " secondes");
            Console.ReadLine();
        }
    }
}