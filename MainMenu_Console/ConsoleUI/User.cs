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

        
        public bool Valid = false;
        /*{
            get;
            set;
        }*/

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
        //bugged, passes data in wrong
        public User(String name, String password)
        {
             String Name = name;
             String Password = password;
             //DataTable UserTable = dt.Copy();
             bool Valid = false;
        }

        public User()
        {
             String Name = "";
             String Password = "";
             bool Valid = false;
        }

        //User Methods

            
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

            //array is empty... WHY?!
            //Console.WriteLine(temptable.Length);
            
            foreach (Object i in temptable)
            {                
                if (i.ToString() == Name)
                {
                    for (int j =0;j<temptable.Length;j++)
                    {
                        if (temptable.GetValue(j).ToString() == Password)
                        {
                            Valid = true;
                        }
                    }
                }
               

        } 
            
        }
    }
}
