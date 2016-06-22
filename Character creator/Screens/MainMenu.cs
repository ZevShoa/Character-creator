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
    public partial class MainMenu : UserControl
    { 
        // Integers, strings, lists, and bools that are called later throughout the program
        public static List<User> userList = new List<User>();
        public static bool failure = false;
        public static bool space1 = true;
        public static bool space2 = true;
        public static bool space3 = true;
        string name, password, score, char1, char2, char3;
        string charName, clothes, colour, weapon,  gender;
        Image charImage;
        public static List<Character> characterList = new List<Character>();
        public static string playerName;
        int index = 1;

        public MainMenu()
        {
            InitializeComponent();

            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Go to leaderboard
            Form f = this.FindForm();
            f.Controls.Remove(this);
            LoginScreen ls = new LoginScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            // Go to signup 
            Form f = this.FindForm();
            f.Controls.Remove(this);
            signUpScreen sus = new signUpScreen();
            sus.Location = new Point((f.Width - sus.Width) / 2, (f.Height - sus.Height) / 2);
            f.Controls.Add(sus);
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            // Go to leaderboard
            Form f = this.FindForm();
            f.Controls.Remove(this);
           LeaderboardScreen ls = new LeaderboardScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            // Go to options
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();
            os.Location = new Point((f.Width - os.Width) / 2, (f.Height - os.Height) / 2);
            f.Controls.Add(os);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Im not sure what this one does
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

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

            // Open the file to be read
            XmlTextReader Reader = new XmlTextReader("Characters.xml");

            // Continue to read each element and text until the file is done
            while (Reader.Read())
            {
                // the loop repeats getting the next piece of information
                if (Reader.NodeType == XmlNodeType.Text)
                {
                    if (index == 1)
                    {
                        charName = Reader.Value;
                        index++;
                    }
                    else if (index == 2)
                    {
                        clothes = Reader.Value;
                        index++;
                    }
                    else if (index == 3)
                    {
                        colour = Reader.Value;
                        index++;
                    }
                    else if (index == 4)
                    {
                        weapon = Reader.Value;
                        index++;

                    }
                    else if (index == 5)
                    {
                        gender = Reader.Value;
                        index++;
                    }
                    else if (index == 6)
                    {
                        charImage = Image.FromFile(reader.Value);
                        //charImage = System.Resources.ResourceManager(Reader.Value, typeof(Resources).Assembly);
                        index = 1;
                        Character newChar = new Character(charName, clothes, weapon, gender, colour, charImage, 300, 250, 5);
                        characterList.Add(newChar);
                    }
                }
            }

            // When done reading the file close it
            Reader.Close();
            index = 1;

        }
    }
}
