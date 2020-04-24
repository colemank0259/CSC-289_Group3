using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            User user = new User(usernameTextBox.Text, passwordTextBox.Text);
            user.Login();
            if(user.Valid == true)
            {
                MessageBox.Show("You have logged in!");
            }
            else
            {
                MessageBox.Show("Username or password was incorrect");
            }
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
