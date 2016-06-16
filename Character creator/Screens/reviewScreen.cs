﻿using System;
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

        public reviewScreen()
        {
            InitializeComponent();
        }
        //used the class to make a character
        public static Character ch = new Character(NameScreen.name, clothingScreen.clothing, weaponScreen.weapon, GenderScreen.gender, colorScreen.color, weaponScreen.finalPic, 100, 100, 5);
        private void reviewScreen_Load(object sender, EventArgs e)
        {
            //set all the values for the screen
            nameLabel.Text = ch.name;
            classLabel.Text = "Class: " + ch.clothes;
            colorLabel.Text = "Color: " + ch.color;
            weaponLabel.Text = "Weapon: " + ch.weapon;
            genderLabel.Text = "Gender: " + ch.gender;
            finalPictureBox.Image = ch.picture;
            
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // goes back a screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            weaponScreen ws = new weaponScreen();
            f.Controls.Add(ws);
            ws.Location = new Point((f.Width - ws.Width) / 2, (f.Height - ws.Height) / 2);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (signUpScreen.createdUser == true)
            {
                //saves users options
                XmlTextWriter writer = new XmlTextWriter("Characters.xml", null);

                writer.WriteStartElement("Character");
                writer.WriteElementString("name", ch.name);
                writer.WriteElementString("class", ch.clothes);
                writer.WriteElementString("color", ch.color);
                writer.WriteElementString("weapon", ch.weapon);
                writer.WriteElementString("gender", ch.gender);
                writer.WriteElementString("image", "Final Image");
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

            // XmlTextWriter writer1 = new XmlTextWriter("UserFile.xml", null);
            // writer1.WriteStartElement(MainMenu.playerName);
            //if(MainMenu.space1 == true)
            // {
            //     writer1.WriteElementString("characterone",ch.name);
            //     writer.WriteEndElement();
            //     writer.Close();
            // }
            //else if (MainMenu.space1 == false)
            // {
            //     if(MainMenu.space2 == true)
            //     {
            //         writer1.WriteElementString("charactertwo",ch.name);
            //         writer.WriteEndElement();
            //         writer.Close();
            //     }
            //     else if(MainMenu.space2 == false)
            //     {
            //         if(MainMenu.space3 == true)
            //         {
            //             writer1.WriteElementString("characterthree",ch.name);
            //             writer.WriteEndElement();
            //             writer.Close();
            //         }
            //     }
            // }
            //goes to the accrual screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            f.Controls.Add(gs);
        }
      
    }
}
