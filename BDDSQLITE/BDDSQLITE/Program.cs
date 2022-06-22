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

            AddData("Billie", "Don");
            AddData("Soufiane", "Donnald");
            AddData("Jonie", "Steve");
            AddData("Billie", "Don");
            AddData("Billie", "Don");
            AddData("Billie", "Don");
            AddData("Billie", "Don");
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
            //ajout de données 
            void AddData(string n , string p)
            {
                //connexion à la bdd 
                SQLiteConnection con = new SQLiteConnection("Data Source=d:\\data\\bdd.sqlite;Version=3;");
                con.Open();
                //string sql = "INSERT INTO clients(nom, prenom) VALUES('CAMARA','Daouda')"; 
                string sql = "INSERT INTO clients(nom, prenom) VALUES('" +n +"','" + p +"')";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close(); 

            }

        }
    }
}
