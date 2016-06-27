using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_creator
{
    public partial class GiftScreen : UserControl
    {
        Random rand = new Random();
        int monsterStart;
        public GiftScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sets next monster and moves to game screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueButton_Click(object sender, EventArgs e)
        {
            monsterStart = rand.Next(0, 2);
            if (monsterStart == 0)
            {
                GameScreen.m = new Monsters(-300, 400, 300, 4, rand.Next(0, 3));
            }
            if (monsterStart == 1)
            {
                GameScreen.m = new Monsters(900, 400, 300, 4, rand.Next(0, 3));
            }
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }
        /// <summary>
        /// saves all scores, shows the player the score and gives player some energy and health
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiftScreen_Load(object sender, EventArgs e)
        {
            if (MainMenu.musicStopped == true)
            {
                Form1.player.PlayLooping();
                MainMenu.musicStopped = false;
            }

            battleScoreLabel.Text = "Battle Score: " + Convert.ToString(BattleScreen.scoreIncrease);
            totalScoreLabel.Text = "Total Score: " + Convert.ToString(GameScreen.totalScore);
            if (BattleScreen.scoreIncrease >= 80)
            {
                energyGiftLabel.Text = Convert.ToString(100 - BattleScreen.humanEnergy) + "% Energy";
                healthGiftLabel.Text = Convert.ToString(100 - BattleScreen.humanHealth) + "% Health";
                BattleScreen.humanEnergy = 100;
                BattleScreen.humanHealth = 100;
            }
            else if (BattleScreen.scoreIncrease >= 60 && BattleScreen.scoreIncrease < 80)
            {
                energyGiftLabel.Text = Convert.ToString(90 - BattleScreen.humanEnergy) + "% Energy";
                healthGiftLabel.Text = Convert.ToString(90 - BattleScreen.humanHealth) + "% Health";
                BattleScreen.humanEnergy = 90;
                BattleScreen.humanHealth = 90;
            }
            else if (BattleScreen.scoreIncrease >= 30 && BattleScreen.scoreIncrease < 60)
            {
                energyGiftLabel.Text = Convert.ToString(80 - BattleScreen.humanEnergy) + "% Energy";
                healthGiftLabel.Text = Convert.ToString(80 - BattleScreen.humanHealth) + "% Health";
                BattleScreen.humanEnergy = 80;
                BattleScreen.humanHealth = 80;
            }
            else if (BattleScreen.scoreIncrease < 30)
            {
                energyGiftLabel.Text = Convert.ToString(70 - BattleScreen.humanEnergy) + "% Energy";
                healthGiftLabel.Text = Convert.ToString(70 - BattleScreen.humanHealth) + "% Health";
                BattleScreen.humanEnergy = 70;
                BattleScreen.humanHealth = 70;
            }
        }
    }
}
