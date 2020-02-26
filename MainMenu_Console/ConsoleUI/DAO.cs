using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace ConsoleUI
{
    public class DAO
    {
        //Properties
        

        //Database connection
        public SQLiteConnection sqlite;

        //Constructors
        public DAO()
        {
            //get current directory and connect to DB file, only returns ConsoleUI/bin/Debug
            string directory = Environment.CurrentDirectory;
            //Console.WriteLine(directory);
            sqlite = new SQLiteConnection("Data Source="+ directory +"/proto.sqlite");

        }

        
        public DataTable getUserTable()
        {
            //necessary stuff? need to experiment further...
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            sqlite.Open(); //Initiate connection to the db
            
            SQLiteCommand cmd;
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "SELECT * FROM User"; //set the query //BUGGED
            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt); //fill the datasource
            
            sqlite.Close();

            return dt;
        }

    }
}
