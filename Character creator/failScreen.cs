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
    public partial class failScreen : UserControl
    {
        public failScreen()
        {
            InitializeComponent();
        }

        private void failScreen_Load(object sender, EventArgs e)
        {
            //shows players score
            scoreLabel.Text = "Score:" + Convert.ToString(GameScreen.totalScore);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes the program if player rage quits
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //goes back to main menu
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            f.Controls.Add(mm);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
        }
    }
}
