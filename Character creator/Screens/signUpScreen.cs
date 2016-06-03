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

namespace Character_creator
{
    public partial class signUpScreen : UserControl
    {
        string name, password, score, char1, char2, char3;
        public signUpScreen()
        {
            InitializeComponent();
        }

        private void signUpScreen_Load(object sender, EventArgs e)
        {
            usernameBox.MaxLength = 8;
            passwordBox.MaxLength = 8;
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

            if (MainMenu.failure == true)
            {
                errorLabel.Text = "Account Already Exists";
                usernameBox.Text = "";
                passwordBox.Text = "";
            }
            else if (MainMenu.failure == false)
            {
                name = usernameBox.Text;
                password = passwordBox.Text;
                score = "";
                char1 = "";
                char2 = "";
                char3 = "";

                User newUser = new User(name, password, score, char1, char2, char3);
                MainMenu.userList.Add(newUser);
            }

            if (MainMenu.failure == false)
            {
                XmlTextWriter writer = new XmlTextWriter("UserFile.xml", null);
                writer.WriteStartElement("player");

                for (int i = 0; i < MainMenu.userList.Count; i++)
                {
                    writer.WriteStartElement("username", MainMenu.userList[i].username);

                    writer.WriteElementString("password", MainMenu.userList[i].password);
                    writer.WriteElementString("score", MainMenu.userList[i].score);
                    writer.WriteElementString("characterone", MainMenu.userList[i].character1);
                    writer.WriteElementString("charactertwo", MainMenu.userList[i].character2);
                    writer.WriteElementString("characterthree", MainMenu.userList[i].character3);

                    // end the elements
                    writer.WriteEndElement();
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
