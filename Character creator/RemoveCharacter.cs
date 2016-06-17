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


        private void char1Button_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    signUpScreen.createdUser = true;
                    MainMenu.userList[i].character1 = "space";
                        MainMenu.space1 = true;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        NameScreen ns = new NameScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);
                }
                i++;
            }
        }

        private void char2Button_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    signUpScreen.createdUser = true;
                    MainMenu.userList[i].character2 = "space";
                        MainMenu.space2 = true;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        NameScreen ns = new NameScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);
                   
                }
                i++;
            }
        }

        private void char3Button_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                        signUpScreen.createdUser = true;
                        MainMenu.userList[i].character3 = "space";
                        MainMenu.space3 = true;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        NameScreen ns = new NameScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);
                }
                i++;
            }
        }

        private void RemoveCharacter_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                        char1Button.Text = MainMenu.userList[i].character1;
                        char2Button.Text = MainMenu.userList[i].character2;
                        char3Button.Text = MainMenu.userList[i].character3;
                }
                i++;
            }
        }
    }
}
