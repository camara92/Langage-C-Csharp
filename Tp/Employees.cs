using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp
{
    internal class Employees
    {

        //déclaration des attributs 
        private int matricule;
        private string nom;
        private string prenom;
        private string dateNaissance;
        private string dateEmbauche;
        private double salaire;

        //constructeur pour les attributs 
        public Employees(int matricule, string nom, string prenom, string dateNaissance, string dateEmbauche, double salaire)
        {

            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;
        }

        public Employees()
        {
            /* this.matricule = 0;
             this.prenom = prenom;
             this.nom = nom;
             this.dateNaissance = dateNaissance;
             this.dateEmbauche = dateEmbauche;*/

        }

        //getters et setters de mes attributs 

        public void setMatricule(int matricule)
        {
            this.matricule = matricule;
        }
        public void getMatricule()
        {
            this.matricule = matricule;

        }
        public void setNom(string nom)
        {
            nom = nom;
        }
        public string getNom()
        {
            return nom;
        }
        public void setPrenom(string prenom)
        {
            prenom = prenom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public void setDateNaissance(string dateNaissance)
        {
            dateNaissance = dateNaissance;
        }
        public string getDateNaissance()
        {
            return dateNaissance;
        }
        public void setDateEmbauche(string dateEmbauche)
        {
            dateEmbauche = dateEmbauche;
        }
        public string getDateEmbauche()
        {
            return dateEmbauche;
        }
        public void setSalaire(double salaire)
        {
            salaire = salaire;
        }
        public double getSalaire()
        {
            return salaire;
        }
        //méthodes 
        public void AfficherInfoEmploye()
        {
            Console.WriteLine("- Le matricule de l'employé est : " + matricule);
            Console.WriteLine("- Le nom de l'employé est : " + nom);
            Console.WriteLine("- Le prénom de l'employé est : " + prenom);
            Console.WriteLine("- Le nom de l'employé est : " + dateNaissance);
            Console.WriteLine("- Le nom de l'employé est : " + dateEmbauche);
            Console.WriteLine("- Le nom de l'employé est : " + salaire);
            Console.WriteLine(" - Mon salire a augmenté de :" + AugmenterSalaire());
        }
        //ancienneté d'un salarié 
        public int DonnerAnciennete()
        {
            int nbanneeAnciennete;
            int n;
            n = Int32.Parse(getDateEmbauche());
            nbanneeAnciennete = 2022 - n;
            return nbanneeAnciennete;
        }
        //nb annee ancienneté <5 ==> augmente de 2% de son salaire 
        //5<nb annee anciennete <=10 => +5% 
        //nb annee anciennete >10 => augmente de 10%
        public double AugmenterSalaire()
        {
            int nbanneeanciennete =3;
            double salaire;
            nbanneeanciennete = DonnerAnciennete();
            {

                if (nbanneeanciennete < 5)
                {
                    salaire = getSalaire() + getSalaire() * 2 / 100;
                }
                else if (nbanneeanciennete >= 5 && nbanneeanciennete < 10)
                {
                    salaire = getSalaire() + getSalaire() * 5 / 100;
                }
                else
                {
                    salaire = getSalaire() + getSalaire() * 10 / 100;
                }
                setSalaire(salaire);
                return salaire;

            }

        }
    }
}
