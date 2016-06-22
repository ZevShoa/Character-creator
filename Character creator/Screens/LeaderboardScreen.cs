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
    public partial class LeaderboardScreen : UserControl
    {
        //List<Highscore> scoreList = new List<Highscore>();
        List<int> scoreList = new List<int>();
        int topFiveOrLess;

        public LeaderboardScreen()
        {

            // adding highscore of new player
            //Highscore h = new Highscore(GameScreen.totalScore, MainMenu.playerName);
            InitializeComponent();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //going back to main form
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the game
            Application.Exit();
        }

        private void LeaderboardScreen_Load(object sender, EventArgs e)
        {
            //checks each user in the userlist 
            int i = 0;
            foreach (User newUser in MainMenu.userList)
            {
                //converts the users score at that location to an int value and adds it to a list
                scoreList.Add(Convert.ToInt16(MainMenu.userList[i].score));
                i++;
            }
            i = 0;
            //sorts the list from smallest to largest score
            scoreList.Sort();
            scoreList.Reverse();
            if (scoreList.Count >= 5)
            {
                topFiveOrLess = 5;
            }
            else
            {
                topFiveOrLess = scoreList.Count;
            }

            //displays, in order, the top 5 scores and their users name
            for (int s = 0; s <= topFiveOrLess - 1; s++)
            {
                foreach (User newUser in MainMenu.userList)
                {
                    if (Convert.ToInt16(MainMenu.userList[i].score) == scoreList[s])
                    {
                        label1.Text = label1.Text + "\n" + MainMenu.userList[i].username + ": " + MainMenu.userList[i].score;
                        break;
                    }
                    i++;
                }
                i = 0;
            }
        }
    }
}          