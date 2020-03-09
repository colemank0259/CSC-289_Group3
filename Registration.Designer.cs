namespace ConsoleUI
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.inputPasswordLabel = new System.Windows.Forms.Label();
            this.inputUsernameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(120, 57);
            this.inputPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(113, 20);
            this.inputPasswordTextBox.TabIndex = 11;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(120, 33);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(113, 20);
            this.usernameTextBox.TabIndex = 10;
            // 
            // inputPasswordLabel
            // 
            this.inputPasswordLabel.AutoSize = true;
            this.inputPasswordLabel.Location = new System.Drawing.Point(34, 60);
            this.inputPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputPasswordLabel.Name = "inputPasswordLabel";
            this.inputPasswordLabel.Size = new System.Drawing.Size(80, 13);
            this.inputPasswordLabel.TabIndex = 9;
            this.inputPasswordLabel.Text = "Input Password";
            // 
            // inputUsernameLabel
            // 
            this.inputUsernameLabel.AutoSize = true;
            this.inputUsernameLabel.Location = new System.Drawing.Point(32, 36);
            this.inputUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputUsernameLabel.Name = "inputUsernameLabel";
            this.inputUsernameLabel.Size = new System.Drawing.Size(82, 13);
            this.inputUsernameLabel.TabIndex = 8;
            this.inputUsernameLabel.Text = "Input Username";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(142, 162);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(42, 162);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(67, 28);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(120, 81);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(113, 20);
            this.confirmPasswordTextBox.TabIndex = 13;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(23, 84);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 12;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 222);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.inputPasswordLabel);
            this.Controls.Add(this.inputUsernameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label inputPasswordLabel;
        private System.Windows.Forms.Label inputUsernameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
    }
}