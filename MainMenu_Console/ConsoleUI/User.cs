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

            //can't be tested because the DAO is buggy
        public bool ValidateUser()
        {
            /*
            //confirming there are no rows of data in the table and that arrays below were not the problem
            foreach (DataRow row in UserTable.Rows) { Console.WriteLine("row"); }
            */

            //put the data from the table into an array for reasons
            Array temptable = UserTable.Select();

            //array is empty... WHY?!
            Console.WriteLine(temptable.Length);
            /*
            foreach (Object i in temptable)
            {                
                if (i.ToString() == Name)
                {
                    for (int j =0;j<temptable.Length;j++)
                    {
                        if (temptable.GetValue(j).ToString() == Password)
                        {
                            valid = true;
                        }
                    }
                }
               

        } */
            return valid;
        }
    }
}
