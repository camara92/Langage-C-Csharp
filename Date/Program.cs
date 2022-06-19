using System;
namespace DateHeure
{

    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Salut le Dev"); 

            Console.ReadLine();
        }
    }
}