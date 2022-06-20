using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesEmployes
{
    internal class Employe
    {
        //déclaration des attributs 
        private int matricule;
        private string nom;
        private string prenom;
        private string dateNaissance;
        private string dateEmbauche;
        private double salaire;

        //constructeur pour les attributs 
        public Employe(int matricule, string nom, string prenom, string dateNaissance, string dateEmbauche, double salaire)
        {

            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance; 
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;
        }
        //getters et setters de mes attributs 

        public void setMatricule(int matricule)
        {
            matricule = matricule; 
        }
        public void int getMatricule()
        {
            return matricule; 

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
        public string getSalaire()
        {
            return salaire;
        }
        //méthodes 

    }
}
