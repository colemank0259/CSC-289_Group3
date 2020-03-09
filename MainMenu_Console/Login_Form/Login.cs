using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Login_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_in.Text.Trim() == "" && password_in.Text.Trim() == "" )
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "SELECT * FROM user WHERE username= @username_in AND password= @password_in";
                SQLiteConnection sqlite = new SQLiteConnection("Data Source=proto.sqlite;Version=3;");
                sqlite.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, sqlite);
                cmd.Parameters.AddWithValue("@username", username_in.Text);
                cmd.Parameters.AddWithValue("@password", password_in.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You are logged in", "Login Successful");
                }
                else
                {
                    MessageBox.Show("Login Failed", "Error");
                }
            }
        }
    }
}
