using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic; 
namespace Serialisation_objet_Json
{
    class PROGRAM
    {
        
        static void Main(string[] args)
        {
            /*Client c1 = new Client("CAMARA", "Daouda");
            Client c2 = new Client("Lucienne", "Sylla");
            Client c3 = new Client("Camus", "Diallo");*/

            List<Client> listeCLient = new List<Client>();
           /* listeCLient.Add(c1);
            listeCLient.Add(c2);
            listeCLient.Add(c3);*/


            //seralisaer 
            /* string JsonString = JsonSerializer.Serialize(listeCLient);
             File.WriteAllText("d:\\data\\listedata.json", JsonString);
             */




            //Déserializer 
            string JsonString = File.ReadAllText("d:\\data\\listedata.json"); 
           listeCLient = JsonSerializer.Deserialize<List<Client>>(JsonString);
           // c2.Information();
           foreach(Client client in listeCLient)
            {
                client.Information();
            }

            Console.ReadLine(); 

        }
    }
}
