﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;


namespace Character_creator
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
       
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            //makes sure you cant have more than 8 characters
            usernameBox.MaxLength = 8;
            passwordBox.MaxLength = 8;
        }

        private void clickSignUpLabel_Click(object sender, EventArgs e)
        {
            //changes screen when you sign up
            Form f = this.FindForm();
            f.Controls.Remove(this);
            signUpScreen sus = new signUpScreen();
            sus.Location = new Point((f.Width - sus.Width) / 2, (f.Height - sus.Height) / 2);
            f.Controls.Add(sus);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //goes back to main menu
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            //saves all the stuff
            int i = 0;
            foreach(User newUser in MainMenu.userList)
            {
                if(MainMenu.userList[i].username == usernameBox.Text)
                {
                    if(MainMenu.userList[i].password == passwordBox.Text)
                    {
                        MainMenu.playerName = usernameBox.Text;
                        signUpScreen.createdUser = false;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        OldOrNewCharacter onc = new OldOrNewCharacter();
                        onc.Location = new Point((f.Width - onc.Width) / 2, (f.Height - onc.Height) / 2);
                        f.Controls.Add(onc);
                        break;   
                    }
                    else
                    {
                        errorLabel.Text = "Incorrect Username Or Password";
                        usernameBox.Text = "";
                        passwordBox.Text = "";
                    }
                }
                i++;
            }
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            Application.Exit();
        }

        private void usernameBox_Validating(object sender, CancelEventArgs e)
        {
            //makes sure that there is no odd characters
            errorProvider1.Clear();


            string error = null;

            var regex = new Regex(@"[^a-zA-Z0-9]");
            if (regex.IsMatch(usernameBox.Text))
   
            {
                error = "This character is invalid";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void passwordBox_Validating(object sender, CancelEventArgs e)
        {
            //make sure that ther is no characters
            errorProvider1.Clear();


            string error = null;

            var regex = new Regex(@"[^a-zA-Z0-9]");
            if (regex.IsMatch(passwordBox.Text))

            {
                error = "This character is invalid";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            //makes the characters in the password box asterisks
           passwordBox.PasswordChar = '*';
        }
    }
}
