using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace ConsoleUI
{
    public class User
    {
        //Properties
        public String Name
        {
            get { return Name;}
            set {Name = value;}
        }
        public String Password
        {
            get { return Password; }
            set { Password = value; }
        }

        //Database connection
        public SQLiteConnection sqlite;

        //Constructors
        public User(String name, String password)
        {
            String Name = name;
            String Password = password;
            //get current directory and connect to DB file
            string directory = Environment.CurrentDirectory;
            sqlite = new SQLiteConnection("Data Source="+ directory +"/proto.sqlite");

        }

        public User()
        {
            String Name = "";
            String Password = "";
        }

        public void getUserTable()
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
            
        }

    }
}
