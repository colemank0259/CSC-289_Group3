﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (inputPasswordTextBox.Text == confirmPasswordTextBox.Text)
            {
                String username = usernameTextBox.Text;
                String password = inputPasswordTextBox.Text;
                               
                //create user object
                User user = new User(username, password);

                //register user
                user.Register();
            }
            else { MessageBox.Show("Make sure both entries of your password match"); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
