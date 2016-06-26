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
    public partial class failScreen : UserControl
    {
        public failScreen()
        {
            InitializeComponent();
        }

        private void failScreen_Load(object sender, EventArgs e)
        {
            if (MainMenu.musicStopped == true)
            {
                Form1.player.PlayLooping();
                MainMenu.musicStopped = false;
            }

            //shows players score
            scoreLabel.Text = "Score: " + Convert.ToString(GameScreen.totalScore);
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    if (Convert.ToInt16(MainMenu.userList[i].score) >= GameScreen.totalScore)
                    {
                        highScoreabel.Text = "Your High Score: " + MainMenu.userList[i].score;
                    }
                    else
                    {
                        highScoreabel.Text = "New High Score: " + GameScreen.totalScore;
                        MainMenu.userList[i].score = Convert.ToString(GameScreen.totalScore);
                        BackStory.runOnce = true;
                    }
                }
                i++;
            }

            saveXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes the program if player rage quits
            Application.Exit();
        }

        private static void saveXML()
        {
            XmlTextWriter writer = new XmlTextWriter("UserFile.xml", null);
            writer.WriteStartElement("players");
            for (int i = 0; i < MainMenu.userList.Count(); i++)
            {
                //Start "Employee" element
                writer.WriteStartElement("player");

                writer.WriteElementString("username", MainMenu.userList[i].username);
                writer.WriteElementString("password", MainMenu.userList[i].password);
                writer.WriteElementString("score", MainMenu.userList[i].score);
                writer.WriteElementString("character1", MainMenu.userList[i].character1);
                writer.WriteElementString("character2", MainMenu.userList[i].character2);
                writer.WriteElementString("character3", MainMenu.userList[i].character3);
               

                // end the "Employee" element
                writer.WriteEndElement();
            }
            //Write the XML to file and close the writer
            writer.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //goes back to main menu
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            f.Controls.Add(mm);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
        }
    }
}
