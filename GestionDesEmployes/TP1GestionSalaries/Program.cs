
using System;

namespace GestionDesEmployes
{
    class Program
    {
        static void Main(string[] args)
        {

            Employes MonEmploye = new Employes();
            MonEmploye.setMatricule(15);
            MonEmploye.setPrenom("Douda");
            MonEmploye.setNom("Diallo");
            MonEmploye.setDateNaissance("1992");
            MonEmploye.setDateEmbauche("2002");
            MonEmploye.setSalaire(2500);


            MonEmploye.AfficherInfoEmploye();
            Console.ReadLine();


        }
    }
}