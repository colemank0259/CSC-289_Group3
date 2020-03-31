using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ConsoleUI_NET_Standard
{
    public class User
    {
        private string _name;
        private string _password;
        //Properties

        public User()
        {
            Name = "";
            Password = "";
            bool Valid = false;
        }

        public User(string name, string password)
        {
            _name = name;
            _password = password;

            bool Valid = false;
        }

        public bool Valid = false;
        /*{
            get;
            set;
        }*/

        //Constructors
        //bugged, passes data in wrong
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //User Method

        public void ValidateUser()
        {
            DAO test = new DAO();
            DataTable UserTable = test.getUserTable();

            //Console.WriteLine(UserTable.Columns);

            ///*
            //confirm there are rows of data in the table,       SUCCESS
            foreach (DataRow row in UserTable.Rows)
            {
                Console.WriteLine(row);


            }
            //*/

            //put the data from the table into an array for reasons
            Array temptable = UserTable.Select();
            // Console.WriteLine(temptable[0]);

            foreach (object i in temptable)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine(temptable.Length);

            foreach (DataRow i in temptable)
            {
                Console.WriteLine("in for loop");
                if (i[1].ToString() == _name && i[2].ToString() == _password)
                {
                    Console.WriteLine("name and password verified");
                    Valid = true;


                }


            }
            /*
             foreach (DataRow i in temptable)
            {
                Console.WriteLine("test");
                if (i[1].ToString() == _name)                   
                    {
                    Console.WriteLine("test2");
                    for (int j =0;j<temptable.Length;j++)
                    {
                        if (temptable.GetValue(j).ToString() == _password)
                        {
                            Valid = true;
                        }
                    }
                }
               

            } 
             */

        }
    }
}
