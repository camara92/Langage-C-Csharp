using System; 


namespace Tp
{

    class Program
    {

        static void Main(string[]  args)
        {

            Employees MonEmploye = new Employees(1, "Daouda", "CAMARA", "1992", "2012", 2500);
            MonEmploye.AfficherInfoEmploye();
            MonEmploye.AugmenterSalaire();
            Console.ReadLine();
        }
    }
}