using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ConsoleUI_NET_Standard
{
    public class DAO
    {
        //TODO: Update database stuff (SQLite does not seem to work with .NET Standard)
        //Properties


        //Database connection
        public DbConnection sqlite;

        //Constructors
        public DAO()
        {
            //get current directory and connect to DB file, only returns ConsoleUI/bin/Debug
            string directory = Environment.CurrentDirectory;
            //Console.WriteLine(directory);
            sqlite = new DbConnection("Data Source=" + directory + "/proto.sqlite");

        }

        //not bugged, problem is in passing table to User class
        public DataTable getUserTable()
        {
            //necessary stuff? need to experiment further...
            DataAdapter ad;
            DataTable dt = new DataTable();


            sqlite.Open(); //Initiate connection to the db

            DbCommand cmd;
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "SELECT * FROM User"; //set the query 
            ad = new DataAdapter(cmd);
            ad.Fill(dt); //fill the datasource

            sqlite.Close();

            //see if there is data in the table, SUCCESS
            //foreach (DataRow row in dt.Rows) { Console.WriteLine("row"); }

            return dt;
        }
    }
}
