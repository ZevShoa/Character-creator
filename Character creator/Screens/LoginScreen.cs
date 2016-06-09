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
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            usernameBox.MaxLength = 8;
            passwordBox.MaxLength = 8;
        }

        private void clickSignUpLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            signUpScreen sus = new signUpScreen();
            sus.Location = new Point((f.Width - sus.Width) / 2, (f.Height - sus.Height) / 2);
            f.Controls.Add(sus);
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
            int i = 0;
            foreach(User newUser in MainMenu.userList)
            {
                if(MainMenu.userList[i].username == usernameBox.Text)
                {
                    if(MainMenu.userList[i].password == passwordBox.Text)
                    {
                        MainMenu.playerName = usernameBox.Text;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        OldOrNewCharacter onc = new OldOrNewCharacter();
                        onc.Location = new Point((f.Width - onc.Width) / 2, (f.Height - onc.Height) / 2);
                        f.Controls.Add(onc);
                    }
                    else
                    {
                        errorLabel.Text = "Incorrect Username Or Password";
                        usernameBox.Text = "";
                        passwordBox.Text = "";
                    }
                }
                else
                {
                    errorLabel.Text = "Incorrect Username Or Password";
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                }
                i++;
            }

            ////loads the xml document to be read
            //XmlDocument doc = new XmlDocument();
            //doc.Load("UserFile.xml");
            //XmlNode parent;
            //parent = doc.DocumentElement;

            ////Displays the correct weather information
            //foreach (XmlNode child in parent.ChildNodes)
            //{
            //    if (child.Name == "player")
            //    {

            //        foreach (XmlNode grandChild in child.ChildNodes)
            //        {
            //            if (grandChild.Name == "username")
            //            {
            //                if (grandChild.InnerText == usernameBox.Text)
            //                {
            //                    MainMenu.playerName = usernameBox.Text;
            //                    Form f = this.FindForm();
            //                    f.Controls.Remove(this);
            //                    OldOrNewCharacter onc = new OldOrNewCharacter();
            //                    onc.Location = new Point((f.Width - onc.Width) / 2, (f.Height - onc.Height) / 2);
            //                    f.Controls.Add(onc);
            //                }
            //                if (grandChild.Name == "password")
            //                {
            //                    if (grandChild.InnerText == passwordBox.Text)
            //                    {
            //                        MainMenu.playerName = usernameBox.Text;
            //                        Form f = this.FindForm();
            //                        f.Controls.Remove(this);
            //                        OldOrNewCharacter onc = new OldOrNewCharacter();
            //                        onc.Location = new Point((f.Width - onc.Width) / 2, (f.Height - onc.Height) / 2);
            //                        f.Controls.Add(onc);
            //                    }
            //                    else
            //                    {
            //                        errorLabel.Text = "Incorrect Username Or Password";
            //                        usernameBox.Text = "";
            //                        passwordBox.Text = "";
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //doc.Save("UserFile.xml");
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
