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
    //always us capitals!!!!!!!!!!!!!!
    public partial class reviewScreen : UserControl
    {
        int index = 1;
        public static List<Character>characterList = new List<Character>();
        public reviewScreen()
        {
            InitializeComponent();
        }
        //used the class to make a character
        public static Character ch = new Character(NameScreen.name, clothingScreen.clothing, weaponScreen.weapon, GenderScreen.gender, colorScreen.color, weaponScreen.finalPic, 300, 400, 5);

        private void reviewScreen_Load(object sender, EventArgs e)
        {
            string name = ch.name;
            string clothes = ch.clothes;
            string colour = ch.color;
            string weapon = ch.weapon;
            string gender = ch.gender;

            //set all the values for the screen
            nameLabel.Text = ch.name;
            classLabel.Text = "Class: " + ch.clothes;
            colorLabel.Text = "Color: " + ch.color;
            weaponLabel.Text = "Weapon: " + ch.weapon;
            genderLabel.Text = "Gender: " + ch.gender;
            finalPictureBox.Image = ch.picture;

            // Open the file to be read
            XmlTextReader reader = new XmlTextReader("Characters.xml");

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
                        else if(index == 2)
                        {
                            clothes = reader.Value;
                            index++;
                        }
                        else if (index == 3)
                        {
                            colour = reader.Value;
                            index++;
                        }
                        else if (index == 4)
                        {
                            weapon = reader.Value;
                            index++;

                        }
                        else if (index == 5)
                        {
                            gender = reader.Value;
                            index++;
                        }
                        else if (index == 6)
                        {
                            index++;
                            Character newChar = new Character(name, clothes, weapon, gender, colour, ch.picture, 100, 100, 5);
                            characterList.Add(newChar);
                        }

                    }
                }
            }
            
            // When done reading the file close it
            reader.Close();
            index = 1;

        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (signUpScreen.createdUser == true)
            {
                //saves users options
                XmlTextWriter writer = new XmlTextWriter("Players.xml", null);

                writer.WriteStartElement("Characters");
                for (int z = 0; z < characterList.Count; z++)
                {
                    writer.WriteStartElement("Character");
                    writer.WriteElementString("name", characterList[z].name);
                    writer.WriteElementString("class", characterList[z].clothes);
                    writer.WriteElementString("color", characterList[z].color);
                    writer.WriteElementString("weapon", characterList[z].weapon);
                    writer.WriteElementString("gender", characterList[z].gender);
                    writer.WriteElementString("image", "Final Image");
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Close();
            }
            
            else
            {

            }

            //more xml stuff
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    if (MainMenu.userList[i].character1 == "space")
                    {
                        MainMenu.userList[i].character1 = ch.name;
                    }
                    else
                    {
                        if (MainMenu.userList[i].character2 == "space")
                        {
                            MainMenu.userList[i].character2 = ch.name;
                        }
                        else
                        {
                            if (MainMenu.userList[i].character3 == "space")
                            {
                                MainMenu.userList[i].character3 = ch.name;
                            }
                           
                        }
                    }
                }
                i++;
            }

        }
      
    }
}
