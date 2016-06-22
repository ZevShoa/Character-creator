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
    public partial class reviewScreen : UserControl
    {
        string charName, clothes, colour, weapon, gender;
        Image charImage;
        int index = 1;
        public reviewScreen()
        {
            InitializeComponent();
        }

        //used the class to make a character
        public static Character ch;

        private void reviewScreen_Load(object sender, EventArgs e)
        {
            if (signUpScreen.createdUser == true)
            {
                charName = NameScreen.name;
                clothes = clothingScreen.clothing;
                colour = colorScreen.color;
                weapon = weaponScreen.weapon;
                gender = GenderScreen.gender;
                charImage = weaponScreen.finalPic;
                ch = new Character(charName, clothes, weapon, gender, colour, charImage, 300, 250, 5);
                MainMenu.characterList.Add(ch);

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
                i = 0;
            }
            else
            {
                int b = 0;
                foreach(Character ch in MainMenu.characterList)
                {
                    if(MainMenu.characterList[b].name == OldOrNewCharacter.characterName)
                    {
                        charName = MainMenu.characterList[b].name;
                        clothes = MainMenu.characterList[b].clothes;
                        colour = MainMenu.characterList[b].color;
                        weapon = MainMenu.characterList[b].weapon;
                        gender = MainMenu.characterList[b].gender;
                        charImage = MainMenu.characterList[b].picture;     
                    }
                    b++;
                }

                b = 0;
                ch = new Character(charName, clothes, weapon, gender, colour, charImage, 300, 250, 5);
            }
            nameLabel.Text = charName;
            classLabel.Text = "Class: " + clothes;
            colorLabel.Text = "Colour: " + colour;
            weaponLabel.Text = "Weapon: " + weapon;
            genderLabel.Text = "Gender: " + gender;
            finalPictureBox.Image = charImage;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //saves users options
            XmlTextWriter writer = new XmlTextWriter("Characters.xml", null);

                writer.WriteStartElement("Characters");
                for (int z = 0; z < MainMenu.characterList.Count; z++)
                {
                    writer.WriteStartElement("Character");
                    writer.WriteElementString("name", MainMenu.characterList[z].name);
                    writer.WriteElementString("class", MainMenu.characterList[z].clothes);
                    writer.WriteElementString("color", MainMenu.characterList[z].color);
                    writer.WriteElementString("weapon", MainMenu.characterList[z].weapon);
                    writer.WriteElementString("gender", MainMenu.characterList[z].gender);
                    writer.WriteElementString("image", "Final Image");
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Close();

                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            }
      
    }
}
