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
            //looks to see if there are already three characters made
            if (characterint < 3)
            {
                //moves on if there are less than three
                signUpScreen.createdUser = true;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                NameScreen ns = new NameScreen();
                ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                f.Controls.Add(ns);
            }
            if (characterint == 3)
            {
                //moces to different form to remove character
                Form f = this.FindForm();
                f.Controls.Remove(this);
                RemoveCharacter rc = new RemoveCharacter();
                rc.Location = new Point((f.Width - rc.Width) / 2, (f.Height - rc.Height) / 2);
                f.Controls.Add(rc);
            }
            characterint = 0;
        }

        private void selectOldCharacterButton_Click(object sender, EventArgs e)
        {
            //uses a character the user already made and goes straight to review screen
            characterName = char3Button.Text;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }

        private void OldOrNewCharacter_Load(object sender, EventArgs e)
        {
            //looks for all the characters the user has made
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                if (MainMenu.userList[i].username == MainMenu.playerName)
                {
                    if (MainMenu.userList[i].character1 != "space")
                    {
                        MainMenu.space1 = false;
                        char1Button.Text = MainMenu.userList[i].character1;
                        characterint++;
                    }
                    else
                    {
                        char1Button.Visible = false;
                    }
                    if (MainMenu.userList[i].character2 != "space")
                    {
                        MainMenu.space2 = false;
                        char2Button.Text = MainMenu.userList[i].character2;
                        characterint++;
                    }
                    else
                    {
                        char2Button.Visible = false;
                    }
                    if (MainMenu.userList[i].character3 != "space")
                    {
                        MainMenu.space1 = false;
                        char3Button.Text = MainMenu.userList[i].character3;
                        characterint++;
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
            //loads first character 
            characterName = char1Button.Text;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }

        private void char2Button_Click(object sender, EventArgs e)
        {
            //loads second character
            characterName = char2Button.Text;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }
    }
}   
