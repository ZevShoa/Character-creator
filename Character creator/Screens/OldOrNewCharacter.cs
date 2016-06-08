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
    public partial class OldOrNewCharacter : UserControl
    {
        public static string characterName;
        int characterint = 0;
        public OldOrNewCharacter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterint < 3)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                NameScreen ns = new NameScreen();
                ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                f.Controls.Add(ns);
            }
            if (characterint == 3)
            {

            }
        }

        private void selectOldCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterName != "")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                reviewScreen rs = new reviewScreen();
                rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
                f.Controls.Add(rs);
            }
            else
            {
                errorLabel.Text = "Please Select A Character";
            }
        }

        private void OldOrNewCharacter_Load(object sender, EventArgs e)
        {
            //loads the xml document to be read
            XmlDocument doc = new XmlDocument();
            doc.Load("UserFile.xml");
            XmlNode parent;
            parent = doc.DocumentElement;

            //Displays the correct weather information
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "username")
                {
                    if (child.Attributes["xmlns"].Value == MainMenu.playerName)
                    {
                        foreach (XmlNode grandChild in child.ChildNodes)
                        {
                            if (grandChild.Name == "characterone")
                            {
                                if (grandChild.Name != "")
                                {
                                    MainMenu.space1 = false;
                                   characterBox.Tag = grandChild.InnerText;
                                    characterint++;
                                }   
                                }
                            if (grandChild.Name == "charactertwo")
                            {
                                if (grandChild.Name != "")
                                {
                                    MainMenu.space2 = false;
                                    characterBox.Tag = grandChild.InnerText;
                                    characterint++;
                                }
                            }
                            if (grandChild.Name == "characterthree")
                            {
                                if (grandChild.Name != "")
                                {
                                    MainMenu.space3 = false;
                                    characterBox.Tag = grandChild.InnerText;
                                    characterint++;
                                }
                            }
                      }

                }
            }
        }
    }

        private void characterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterName = characterBox.Text;   
        }
    }
}
