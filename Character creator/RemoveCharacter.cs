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
                            if (grandChild.Name == "character1")
                            {
                                if (grandChild.Name != "")
                                {
                                    characterBox.Tag = grandChild.InnerText;
                                }
                            }
                            if (grandChild.Name == "character1")
                            {
                                if (grandChild.Name != "")
                                {
                                    characterBox.Tag = grandChild.InnerText;
                                }
                            }
                            if (grandChild.Name == "character1")
                            {
                                if (grandChild.Name != "")
                                {
                                    characterBox.Tag = grandChild.InnerText;
                                }
                            }
                        }

                    }
                }
            }
        }

        private void characterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterRemoved = characterBox.Text;
        }

        private void selectOldCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterRemoved != "")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                reviewScreen rs = new reviewScreen();
                rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
                f.Controls.Add(rs);
            }
            else
            {
                errorLabel.Text = "Please Select A Character \nTo Remove or Go Back";
            }
        }
    }
}
