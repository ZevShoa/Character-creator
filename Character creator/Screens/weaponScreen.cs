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
    public partial class weaponScreen : UserControl
    {
        public static  string weapon;
        public weaponScreen()
        {
            InitializeComponent();
        }

        private void swordButton_Click(object sender, EventArgs e)
        {
            weapon = "sword";
            changeScreen();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            weapon = "staff";
            changeScreen();
        }

        private void axeButton_Click(object sender, EventArgs e)
        {
            weapon = "axe";
            changeScreen();
        }

        private void daggerButton_Click(object sender, EventArgs e)
        {
            weapon = "dagger";
            changeScreen();
        }

        private void fistButton_Click(object sender, EventArgs e)
        {
            weapon = "fist";
            changeScreen();
        }

        public void changeScreen()
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            statScreen ss = new statScreen();
            f.Controls.Add(ss);
        }

    }
}
