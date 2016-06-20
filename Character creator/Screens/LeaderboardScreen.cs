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
            //sorts the list from smallest to largest score
            scoreList.Sort();

            //displays, in order, the top 10 scores and their users name
            i = 0;
            for (int s = scoreList.Count(); s > scoreList.Count() - 10; s--)
            {
                foreach (User newUser in MainMenu.userList)
                {
                    if(MainMenu.userList[i].score == Convert.ToString(scoreList[s]))
                    {
                        label1.Text = label1.Text + "\n" + MainMenu.userList[i].username + ": " + MainMenu.userList[i].score;
                    }
                }
            }

            //Check if the total score is < than bronze, silver, etc.. Once total score is < than tier lvl, player is the specified tier
            //if (GameScreen.totalScore < 500)
            //{

            //} 
            //Check if new totalscore is < than previeous high scores 




        }
    }
}          