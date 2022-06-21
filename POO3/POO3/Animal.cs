using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Animal
    {
        //les attributs 
        private string nom;
        private int age;

        //constructeur par défaut 
        public Animal()
        {
           // Console.WriteLine("J'ai ");
           //intérêt de faire passer les infos des attributs 
           //en le supprimant on ne peut passer d'autres infos sans qu'il y ait des infos sur ce dernier 
           //ne s'exécutant qu'au moment de l'instanciation 

        }

       

        /*public string Nom 
{ 
   //on ne peut plus modifier l'information mmais visible dans l'affichage 
   get; private set; 
}*/
        //propriétés 
        public string Nom
       {
            get { 
                //recupérer 
                return nom;}
            set {
                
                //_nom = value;
            
            }
        }
        public int Age
        {
            get
            {
                //recupérer 
                return age;
            }
            set
            {

                if (value > 10)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("L'age doit être supérieur à  10");
                }

            }
        }
        public Animal(string Nom, int Age)
        {
            this.nom = Nom;
            this.age = Age;
        }
       


        //méthodes 
        public void AfficheInfo()
        {
            Console.WriteLine("Je suis "+nom);
            Console.WriteLine("J'ai " + age + "an(s).");
            
        }
    }
}
