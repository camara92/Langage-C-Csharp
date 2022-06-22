using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface Iaddition1
    {
        //propriétés 
        int Nb1 { get; set; }   
        int Nb2 { get; set; }

        void addition();
       
    }
    //on peut créer une interface pour la - mais on peut directement dans cette classe. 
    internal interface ISoustraction
    {
        //propriétés 
        int Nb1 { get; set; }
        int Nb2 { get; set; }

        void soustraction();
        

    }
}
