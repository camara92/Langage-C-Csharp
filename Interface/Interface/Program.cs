using System; 
namespace Interface
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation(); 
            op.Nb1 = 10;
            op.Nb2 = 20;

            op.addition();
            op.soustraction(); 
            Console.ReadLine(); 
        
        
        }
    }

}
