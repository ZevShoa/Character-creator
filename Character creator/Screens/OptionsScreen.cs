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
    public partial class OptionsScreen : UserControl
    {
        public OptionsScreen()
        {
            InitializeComponent();
        }

        private void volumeBar_Click(object sender, EventArgs e)
        {
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (PauseMenu.gameStart == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                PauseMenu pm = new PauseMenu();
                pm.Location = new Point((f.Width - pm.Width) / 2, (f.Height - pm.Height) / 2);
                f.Controls.Add(pm);
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                MainMenu mm = new MainMenu();
                mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
                f.Controls.Add(mm);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {
            if(PauseMenu.gameStart == true)
            {
                menuButton.Text = "Back To Pause Menu";
            }
        }
    }
}
