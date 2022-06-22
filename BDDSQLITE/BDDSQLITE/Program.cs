using System;
using System.IO;
using System.Data.SQLite;
 
namespace Base_de_donnees_sqlite
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            //créer la bdd 
            string bddpath = "d:\\data\\bdd.sqlite";
            if (!File.Exists(bddpath)) CreateBdd(); 
            void CreateBdd()
            {
                SQLiteConnection.CreateFile(bddpath);   
                SQLiteConnection con = new SQLiteConnection("Data Source=d:\\data\\bdd.sqlite;Version=3;");
                con.Open();

                //créer une requête 
                string sql = "create table clients (nom varchar(25), prenom varchar(20)) ";
                SQLiteCommand command = new SQLiteCommand(sql, con);    
                command.ExecuteNonQuery();
                con.Close(); 
            }
            
        }
    }
}
