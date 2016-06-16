using System;
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
    public partial class signUpScreen : UserControl
    {
        string name, password, score, char1, char2, char3;
        public static bool createdUser = false;
        public signUpScreen()
        {
            InitializeComponent();
        }

        private void signUpScreen_Load(object sender, EventArgs e)
        {
            usernameBox.MaxLength = 8;
            passwordBox.MaxLength = 8;

        }

        private void passwordBox_Validating(object sender, CancelEventArgs e)
        {
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
            passwordBox.PasswordChar = '*';
        }

        private void usernameBox_Validating(object sender, CancelEventArgs e)
        {

            errorProvider1.Clear();
            

            string error = null;
            
            var regex = new Regex(@"[^a-zA-Z0-9]");
            if (regex.IsMatch(usernameBox.Text))
            //    if (usernameBox.Text.Length < 3)
            {
                error = "This character is invalid";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickLogInLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            LoginScreen ls = new LoginScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            MainMenu.playerName = usernameBox.Text;
            int z = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[z].username == MainMenu.playerName)
                {
                    errorLabel.Text = "Account Already Exists";
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    MainMenu.failure = true;
                }
                z++;
            }

            if (MainMenu.failure == false)
            {
                createdUser = true;
                name = usernameBox.Text;
                password = passwordBox.Text;
                score = "space";
                char1 = "space";
                char2 = "space";
                char3 = "space";

                User newUser = new User(name, password, score, char1, char2, char3);
                MainMenu.userList.Add(newUser);

                XmlTextWriter writer = new XmlTextWriter("UserFile.xml", null);
                writer.WriteStartElement("players");

                for (int i = 0; i < MainMenu.userList.Count; i++)
                {
                    writer.WriteStartElement("player", "");

                    writer.WriteElementString("username", MainMenu.userList[i].username);

                    writer.WriteElementString("password", MainMenu.userList[i].password);
                    writer.WriteElementString("score", MainMenu.userList[i].score);
                    writer.WriteElementString("characterone", MainMenu.userList[i].character1);
                    writer.WriteElementString("charactertwo", MainMenu.userList[i].character2);
                    writer.WriteElementString("characterthree", MainMenu.userList[i].character3);

                    // end the elements
                    writer.WriteEndElement();
                    MainMenu.playerName = MainMenu.userList[i].username;
                }
                
                writer.WriteEndElement();
                writer.Close();

                Form f = this.FindForm();
                f.Controls.Remove(this);
                NameScreen ns = new NameScreen();
                ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                f.Controls.Add(ns);
            }
            MainMenu.failure = false;
        }
    }
}
