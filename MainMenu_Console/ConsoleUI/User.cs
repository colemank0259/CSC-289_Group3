using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleUI
{
    class User
    {
        //Properties

        DataTable UserTable = new DataTable();
        bool valid = false;

        public String Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public String Password
        {
            get { return Password; }
            set { Password = value; }
        }
       
        //Constructors
        public User(String name, String password, DataTable dt)
        {
            String Name = name;
            String Password = password;
            DataTable UserTable = dt;
        }

        public User()
        {
            String Name = "";
            String Password = "";
        }

        //User Methods

            //doesn't work, but also doesn't throw an error
        public bool ValidateUser()
        {
            //put the data from the table into an array cuz I don't know how to work with a table
            Array temptable = UserTable.Select();
            
            foreach (Object i in temptable)
            {                
                if (i == Name)
                {
                    for (int j =0;j<temptable.Length;j++)
                    {
                        if (temptable.GetValue(j) == Password)
                        {
                            valid = true;
                        }
                    }
                }
            }
            return valid;
        }
    }
}
