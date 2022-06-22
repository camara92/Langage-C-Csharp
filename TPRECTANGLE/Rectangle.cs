using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRECTANGLE
{
    internal class Rectangle
    {
        private float _longueur;
        private float _largeur;

        private string _couleur; 

        public string Couleur
        { 
            //uniquement en lecture 
            get { return _couleur; } 
        }
        //constructeur 
        public Rectangle(float longueur, float largeur)
        {
            this._longueur = longueur;
            this._largeur = largeur;
        }
        //deuxieme constructeur pour gérer la couleur 
        public Rectangle(float longueur, float largeur, string couleur)
        {
            this._longueur = longueur;
            this._largeur = largeur;
            this._couleur = couleur;
        }
        //methode qui permet d'afficher le périmètre dans la console 
        public void Perimetre()
        {
            Console.WriteLine($"Le périmètre est de { (_longueur * _largeur )*2 } mètre(s)");
        }
        //aire retrournée 
        public float Aire()
        {   
            return _longueur* _largeur;
        }
        public void AfficheCouleur()
        {
            string str = _couleur != null ? "Ma couleur est " + _couleur : "Aucune couleur."; 
            Console.WriteLine(str);
        }

    }
}
