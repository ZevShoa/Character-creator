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
        List<Highscore> scoreList = new List<Highscore>();

        
        public LeaderboardScreen()
        {

            // adding highscore of new player
            Highscore h = new Highscore(GameScreen.totalScore, MainMenu.playerName);
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
            //Check if the total score is < than bronze, silver, etc.. Once total score is < than tier lvl, player is the specified tier
            if (GameScreen.totalScore < 500)
            {

            } 
            //Check if new totalscore is < than previeous high scores 
            

           

        }
    }
}          