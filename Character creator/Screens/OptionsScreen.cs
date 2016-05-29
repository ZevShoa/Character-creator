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
            //int value = 
        }

        private void OptionsScreen_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void volumeBar_MouseDown(object sender, MouseEventArgs e)
        {
            //int x = e.X;
            volumeBar.Value = e.X;

           // int temp = 0;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }
    }
}
