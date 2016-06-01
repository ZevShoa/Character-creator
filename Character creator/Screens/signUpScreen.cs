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
        List<User> userList = new List<User>();
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
            // Open the file to be read
            XmlTextReader reader = new XmlTextReader("User.xml");

            // Continue to read each element and text until the file is done
            while (reader.Read())
            {
                // If the currently read item is text then print it to screen,
                // otherwise the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string newUser = usernameBox.Text;
                    string newPassword = passwordBox.Text;
                }
            }
            // When done reading the file close it
            reader.Close();

            XmlTextWriter writer = new XmlTextWriter("User.xml", null);
            writer.WriteStartElement("player");

            for (int i = 0; i < userList.Count; i++)
            {
                //Start "student" element
                writer.WriteStartElement("player");

                //Write sub-elements
                writer.WriteElementString("username", userList[i].username);
                writer.WriteElementString("password", userList[i].password);
                writer.WriteElementString("score", userList[i].score);
                writer.WriteElementString("username", userList[i].character1);
                writer.WriteElementString("password", userList[i].character2);
                writer.WriteElementString("score", userList[i].character3);

                // end the "student" element
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
    }
}
