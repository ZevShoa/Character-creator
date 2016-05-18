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
    public partial class statScreen : UserControl
    {
        public statScreen()
        {
            InitializeComponent();
        }
        public static int healthStat = 5;
        public static int energyStat = 5;
        int stat = 15;
        private void statScreen_Load(object sender, EventArgs e)
        {
            nameLabel.Text = NameScreen.name;
            labelRefresh();
            
        }

        private void healthPlusButton_Click(object sender, EventArgs e)
        {
            if (stat > 0)
            {
                stat--;
                healthStat++;
                labelRefresh();
                messageLabel.Text = null;
            }
            else
            {
                messageLabel.Text = "You have no more stat points to spend";
            }

        }
        private void healthMinusButton_Click(object sender, EventArgs e)
        {
            if (healthStat > 5)
            {
                stat++;
                healthStat--;
                labelRefresh();
                messageLabel.Text = null;
            }
            else
            {
                messageLabel.Text = "Your health and energy must have a minimum value of 5";
            }
        }

        private void energyPlusButton_Click(object sender, EventArgs e)
        {
            if (stat > 0)
            {
                stat--;
                energyStat++;
                labelRefresh();
                messageLabel.Text = null;
            }
            else
            {
                messageLabel.Text = "You have no more stat points to spend";
            }
        }

        private void energyMinusButton_Click(object sender, EventArgs e)
        {
            if (energyStat > 5)
            {
                stat++;
                energyStat--;
                labelRefresh();
                messageLabel.Text = null;
            }
            else
            {
                messageLabel.Text = "Your health and energy must have a minimum value of 5";
            }
        }

        public void labelRefresh()
        {
            healthLabel.Text = Convert.ToString(healthStat);
            energyLabel.Text = Convert.ToString(energyStat);
            statLabel.Text = Convert.ToString(stat);
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            Form f = this.FindForm();
            f.Controls.Remove(this);
            weaponScreen ws = new weaponScreen();
            f.Controls.Add(ws);
            ws.Location = new Point((f.Width - ws.Width) / 2, (f.Height - ws.Height) / 2);
        }
    }
}
