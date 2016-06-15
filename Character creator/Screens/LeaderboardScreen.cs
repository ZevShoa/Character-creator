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
        List<int> positionList = new List<int>(new int[] { 1, 2, 3, 4, 5});
        
        public LeaderboardScreen()
        {
            Highscore a = new Highscore(GameScreen.totalScore, MainMenu.playerName);
            if (GameScreen.totalScore > positionList[4] && GameScreen.totalScore < positionList[3])
            {
                scoreList.Add(a);
            }
            else
            {
            }
            if (GameScreen.totalScore > positionList[3] && GameScreen.totalScore < positionList[2])
            {
                scoreList.Add(a);
            }
            else
            {

            }
          
            
            InitializeComponent();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LeaderboardScreen_Load(object sender, EventArgs e)
        {
       
        }
    }
}          