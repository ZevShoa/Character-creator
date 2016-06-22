using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Character_creator
{
    public partial class BackStory : UserControl
    {
        public BackStory()
        {
            InitializeComponent();
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {
            instructionsLabel.Text = "You";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " are";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " the";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " last";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " human";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " alive";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " on";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " planet";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " OmiCron.";
            Thread.Sleep(400);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + "\n";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + "But";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " .";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " .";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " .";
            Thread.Sleep(400);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + "\n";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + "You're";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " not";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " alone.";
            Thread.Sleep(400);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + "\nHow";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " Long";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " Will";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " You";
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            instructionsLabel.Text = instructionsLabel.Text + " Survive?";
            startButton.Visible = true;
            Thread.Sleep(200);
            instructionsLabel.Refresh();
            startButton.Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }
    }
}
