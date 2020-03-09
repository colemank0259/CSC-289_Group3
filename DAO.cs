﻿using System;
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
            sqlite = new SQLiteConnection("Data Source=" + directory + "/proto.sqlite");

        }
                
        public DataTable getUserTable()
        {
            //necessary stuff? need to experiment further...
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();


            sqlite.Open(); //Initiate connection to the db

            SQLiteCommand cmd;
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "SELECT * FROM User"; //set the query 
            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt); //fill the datasource

            sqlite.Close();

            //see if there is data in the table, SUCCESS
            //foreach (DataRow row in dt.Rows) { Console.WriteLine("row"); }

            return dt;
        }

        public void insertIntoUserTable(string name, string password)
        {                     

            sqlite.Open(); //Initiate connection to the db

            //variable to hold command for convenience 
            String query = "INSERT INTO User(username, password) VALUES('" + name + "', '" + password + "')";

            SQLiteCommand cmd;
            cmd = sqlite.CreateCommand();
            cmd.CommandText = query; //set the command             
            
            //Execute Command
            cmd.ExecuteNonQuery();
            
            sqlite.Close();
        }

    }
}
