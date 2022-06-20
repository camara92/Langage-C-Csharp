using System; 
namespace GestionEMployes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe MesInfo = new Employe(); 
            MesInfo.matricule = 0001; 

            MesInfo.AfficherInfoEmploye();
            Console.ReadLine(); 
          
        }
    }
}
