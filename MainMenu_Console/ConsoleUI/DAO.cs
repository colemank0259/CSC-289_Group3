using System;
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

        public DataTable getUser(string username, string password)
        {

                sqlite.Open();
                DataTable dt = new DataTable();
                DataTable salt = new DataTable();

                //if username in DB, get salt
                string saltquery = "SELECT salt FROM user WHERE username= @username";
                SQLiteCommand saltcmd = new SQLiteCommand(saltquery, sqlite);
                saltcmd.Parameters.AddWithValue("@username", username);
                SQLiteDataAdapter saltDA = new SQLiteDataAdapter(saltcmd);
                saltDA.Fill(salt);

                Array saltArray = salt.Select();
                foreach(DataRow i in saltArray)
                {
                    if (i[0].ToString() != "")
                    {
                    string saltedPassword = String.Concat(password,i[0]);
                    string saltedHashedPassword = saltedPassword.GetHashCode().ToString();
                    //perform 2nd query
                    string query = "SELECT username, password FROM user WHERE username= @username AND password= @password";
                    SQLiteCommand cmd = new SQLiteCommand(query, sqlite);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", saltedHashedPassword);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    }
                }

                
                            

            return dt;
        }

        public void insertIntoUserTable(string name, string password, string salt)
        {                     

            sqlite.Open(); //Initiate connection to the db

            //variable to hold command for convenience 
            String sql = "INSERT INTO User(username, password, salt) VALUES('" + name + "', '" + password + "' , '"+ 
                salt +"')";

            SQLiteCommand cmd;
            cmd = sqlite.CreateCommand();
            cmd.CommandText = sql; //set the command             
            
            //Execute Command
            cmd.ExecuteNonQuery();
            
            sqlite.Close();
        }

    }
}
