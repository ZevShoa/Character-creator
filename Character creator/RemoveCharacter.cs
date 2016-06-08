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
    public partial class RemoveCharacter : UserControl
    {
        string characterRemoved;
        public RemoveCharacter()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OldOrNewCharacter onc = new OldOrNewCharacter();
            onc.Location = new Point((f.Width - onc.Width) / 2, (f.Height - onc.Height) / 2);
            f.Controls.Add(onc);
        }

        private void RemoveCharacter_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    characterBox.Tag = MainMenu.userList[i].character1;
                    characterBox.Tag = MainMenu.userList[i].character2;
                    characterBox.Tag = MainMenu.userList[i].character3;
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
            //    if (child.Name == "username")
            //    {
            //        if (child.Attributes["xmlns"].Value == MainMenu.playerName)
            //        {
            //            foreach (XmlNode grandChild in child.ChildNodes)

            //            {
            //                if (grandChild.Name == "character1")
            //                {
            //                    if (grandChild.Name != "")
            //                    {
            //                        characterBox.Tag = grandChild.InnerText;
            //                    }
            //                }
            //                if (grandChild.Name == "character2")
            //                {
            //                    if (grandChild.Name != "")
            //                    {
            //                        characterBox.Tag = grandChild.InnerText;
            //                    }
            //                }
            //                if (grandChild.Name == "character3")
            //                {
            //                    if (grandChild.Name != "")
            //                    {
            //                        characterBox.Tag = grandChild.InnerText;
            //                    }
            //                }
            //            }

            //        }
            //    }
            //}
        }

        private void characterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterRemoved = characterBox.Text;
        }

        private void selectOldCharacterButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                   if(MainMenu.userList[i].character1 == characterRemoved)
                    {
                        MainMenu.userList[i].character1 = "space";
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        NameScreen ns = new NameScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);
                    }
                    if (MainMenu.userList[i].character2 == characterRemoved)
                    {
                        MainMenu.userList[i].character2 = "space";
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        NameScreen ns = new NameScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);
                    }
                    if (MainMenu.userList[i].character3 == characterRemoved)
                    {
                        MainMenu.userList[i].character3 = "space";
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        NameScreen ns = new NameScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);
                    }
                }
                i++;
            }
            
        }
    }
}
