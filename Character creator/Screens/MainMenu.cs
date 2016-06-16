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
using System.Media;

// May 26 - updated UI

namespace Character_creator
{
    public partial class MainMenu : UserControl
    {
        
        public static SoundPlayer player = new SoundPlayer(Properties.Resources.DARK__Video_Game____Main_Theme_Music);
        public static List<User> userList = new List<User>();
        public static bool failure = false;
        public static bool space1 = true;
        public static bool space2 = true;
        public static bool space3 = true;
        string name, password, score, char1, char2, char3;
        public static string playerName;
        int index = 1;

        public MainMenu()
        {
            InitializeComponent();

            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            LoginScreen ls = new LoginScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            signUpScreen sus = new signUpScreen();
            sus.Location = new Point((f.Width - sus.Width) / 2, (f.Height - sus.Height) / 2);
            f.Controls.Add(sus);
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
           LeaderboardScreen ls = new LeaderboardScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();
            os.Location = new Point((f.Width - os.Width) / 2, (f.Height - os.Height) / 2);
            f.Controls.Add(os);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Sounds
           
            player.PlayLooping();

            // Open the file to be read
            XmlTextReader reader = new XmlTextReader("UserFile.xml");

            // Continue to read each element and text until the file is done
            while (reader.Read())
            {
                // the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        if (index == 1)
                        {
                            name = reader.Value;
                            index++;
                        }
                        else if (index == 2)
                        {
                            password = reader.Value;
                            index++;
                        }
                        else if (index == 3)
                        {
                            score = reader.Value;
                            index++;

                        }
                        else if (index == 4)
                        {
                            char1 = reader.Value;
                            index++;
                        }
                        else if (index == 5)
                        {
                            char2 = reader.Value;
                            index++;
                        }
                        else if (index == 6)
                        {
                            char3 = reader.Value;

                            index = 1;
                            User newUser = new User(name, password, score, char1, char2, char3);
                            userList.Add(newUser);
                        }
                    }
                }
            }
            // When done reading the file close it
            reader.Close();
            
        }
    }
}
