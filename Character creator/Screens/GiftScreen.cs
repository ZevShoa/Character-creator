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
        public GiftScreen()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void GiftScreen_Load(object sender, EventArgs e)
        {
            battleScoreLabel.Text = Convert.ToString(BattleScreen.scoreIncrease);
            totalScoreLabel.Text = Convert.ToString(GameScreen.totalScore);
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
