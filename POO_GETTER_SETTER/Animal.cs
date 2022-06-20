using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GETTER_SETTER
{
    internal class Animale
    {   //si on ne spécfie rien il est en private 
        private string _nom;
        private int _age;

        //créer des propriétés que sont les getters et setters 
        public string Nom
        {
            get {
                return _nom; 
            }
            set
            {
                // _nom= value;
                Console.WriteLine("Le nom ne peut pas être changé"); 
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                // _age = value;
                if (value > 1)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("L'age doit être supérieure à 1."); 
                }
            }
        }
        public Animale(string Nom, int Age)
        {
            this._nom = Nom;
            this._age = Age;
        }
        public void AfficheInfo()

        {

            Console.WriteLine("Je suis " + _nom);
            Console.WriteLine("J'ai " + _age + "an(s)");

        }

    }
}
