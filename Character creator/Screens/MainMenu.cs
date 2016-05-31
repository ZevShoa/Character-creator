using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// May 26 - updated UI

namespace Character_creator
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void newUserButton_Click(object sender, EventArgs e)
        {

        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();

            this.Controls.Add(os);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
