using System;
using System.Data;
using System.Security.Cryptography;


namespace ConsoleUI
{
    public class User
    {
        public bool Valid = false;
        Random random = new Random();
        private string _name;
        private string _password;
        private int _saltnum;

        //Properties

        public User()
        {
            Name = "";
            Password = "";
            bool Valid = false;
            _saltnum = random.Next(0,99999);
        }

        public User(String name, String password)
        {
            _name = name;
            _password = password;

            bool Valid = false;
            _saltnum = random.Next(0,99999);
        }
              
        
        //Constructors       
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

        //User Methods

        public void Validate()
        {
            DAO dao = new DAO();
            DataTable UserTable = dao.getUserTable();

            
            /*
            //confirm there are rows of data in the table,       SUCCESS
            foreach (DataRow row in UserTable.Rows) {  Console.WriteLine(row);}
            */

            //put the data from the table into an array for processing
            Array temptable = UserTable.Select();
                        
            
            foreach (DataRow i in temptable)
            {                
                if (i[1].ToString() == _name && i[2].ToString() == _password)
                {                    
                    Valid = true;                    
                }


            }
            
        }

        public void Login()
        {
            DAO dao = new DAO();
            DataTable userLogin = dao.getUser(_name, _password);
            if(userLogin.Rows.Count > 0) { Valid = true; }
        }

        public void Register()
        {
                       
            //salt and hash password before user info is entered into DB
            //create a random salt
            RNGCryptoServiceProvider regRNG = new RNGCryptoServiceProvider();
            byte[] salt = new byte[_saltnum];
            regRNG.GetBytes(salt);
            string strSalt = Convert.ToBase64String(salt);
            //hash password
            string saltAndPwd = String.Concat(_password, strSalt);            
            string hashedPwd = saltAndPwd.GetHashCode().ToString();
            

            DAO dao = new DAO();
            dao.insertIntoUserTable(_name, hashedPwd, strSalt);
        }
    }
}
