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
    public partial class colorScreen : UserControl
    {
        public static string color;
        public colorScreen()
        {
            InitializeComponent();
        }
      

        private void colorScreen_Load(object sender, EventArgs e)
        {

            nameLabel.Text = NameScreen.name;

            
        }
        #region mouse enter/leave
        private void purpleButton_MouseEnter(object sender, EventArgs e)
        {
            colorBox.Image = Properties.Resources.purple;
        }

        private void purpleButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }

        private void yellowButton_MouseEnter(object sender, EventArgs e)
        {
            colorBox.Image = Properties.Resources.yellow;
        }

        private void yellowButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }

        private void redButton_MouseEnter(object sender, EventArgs e)
        {
            colorBox.Image = Properties.Resources.red;
        }

        private void redButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }

        private void greenButton_MouseEnter(object sender, EventArgs e)
        {
            colorBox.Image = Properties.Resources.green;
        }

        private void greenButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }
        #endregion

        private void purpleButton_MouseClick(object sender, MouseEventArgs e)
        {
            color = "purple";
            changeScreen();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            color = "yellow";
            changeScreen();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            color = "red";
            changeScreen();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            color = "green";
            changeScreen();
        }

        public void changeScreen()
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            clothingScreen cs = new clothingScreen();
            f.Controls.Add(cs);
        }

    }
}
