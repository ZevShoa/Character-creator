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
    public partial class PauseMenu : UserControl
    {
        public static bool gameStart = false;
        public PauseMenu()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            // goes to option screen
            gameStart = true;
            Form z = this.FindForm();
            z.Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();
            os.Location = new Point((z.Width - os.Width) / 2, (z.Height - os.Height) / 2);
            z.Controls.Add(os);
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            //goes back to game screen
            Form z = this.FindForm();
            z.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            gs.Location = new Point((z.Width - gs.Width) / 2, (z.Height - gs.Height) / 2);
            z.Controls.Add(gs);
        }
    }
}
