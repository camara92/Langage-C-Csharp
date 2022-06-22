using System;

namespace TPRECTANGLE
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            //si float on met un f 
            Rectangle rec = new Rectangle(17.5f, 25.3f, "Rouge");
            Rectangle rec1 = new Rectangle(158.5f, 215.3f);
            rec.Perimetre();
            rec1.Perimetre();
            //rec.Couleur = noir;
            Console.WriteLine(rec.Couleur);
            Console.WriteLine(rec1.Couleur);
            Console.WriteLine("L'aire est "+rec.Aire());
            rec.AfficheCouleur();
            rec1.AfficheCouleur();
            Console.ReadLine();
        }
    }
}
