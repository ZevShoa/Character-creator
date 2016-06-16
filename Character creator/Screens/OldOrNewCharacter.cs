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

            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }

        private void OldOrNewCharacter_Load(object sender, EventArgs e)
        {

            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    if (MainMenu.userList[i].character1 != "space")
                    {
                        MainMenu.space1 = false;
                        char1Button.Text = MainMenu.userList[i].character1;
                    }
                    else
                    {
                        char1Button.Visible = false;
                    }
                    if (MainMenu.userList[i].character2 != "space")
                    {
                        MainMenu.space2 = false;
                        char2Button.Text = MainMenu.userList[i].character2;
                    }
                    else
                    {
                        char2Button.Visible = false;
                    }
                    if (MainMenu.userList[i].character3 != "space")
                    {
                        MainMenu.space1 = false;
                        char3Button.Text = MainMenu.userList[i].character3;
                    }
                    else
                    {
                        char3Button.Visible = false;
                    }

                    if (MainMenu.userList[i].character1 == "space" && MainMenu.userList[i].character2 == "space" && MainMenu.userList[i].character3 == "space")
                    {
                        errorLabel.Text = "You Have No Existing Characters. Create New";
                    }
                }
                i++;
            }
         }

        private void char1Button_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }

        private void char2Button_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }
    }
}
