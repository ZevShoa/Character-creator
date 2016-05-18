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
    public partial class clothingScreen : UserControl
    {
        public string clothing;
        public clothingScreen()
        {
            InitializeComponent();
        }

        private void clothingScreen_Load(object sender, EventArgs e)
        {
            nameLabel.Text = NameScreen.name;
        }
        #region Mouse Enter/Leave
        private void knightButton_MouseEnter(object sender, EventArgs e)
        {
            clothingBox.Image = Properties.Resources.knight;
        }

        private void knightButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void peasentButton_MouseEnter(object sender, EventArgs e)
        {
            clothingBox.Image = Properties.Resources.peseant;
        }

        private void peasentButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void mageButton_MouseEnter(object sender, EventArgs e)
        {
            clothingBox.Image = Properties.Resources.mage;
        }

        private void mageButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void rogueButton_MouseEnter(object sender, EventArgs e)
        {
            clothingBox.Image = Properties.Resources.rogue;
        }

        private void rogueButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void deprivedButton_MouseEnter(object sender, EventArgs e)
        {
            clothingBox.Image = Properties.Resources.deprived;        }

        private void deprivedButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }
        #endregion

        #region Buttons Clicks
        private void knightButton_Click(object sender, EventArgs e)
        {
            clothing = "Knight";
            changeScreen();
        }

        private void peasentButton_Click(object sender, EventArgs e)
        {
            clothing = "Peasant";
            changeScreen();
        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            clothing = "Mage";
            changeScreen();
        }

        private void rogueButton_Click(object sender, EventArgs e)
        {
            clothing = "Rogue";
            changeScreen();
        }

        private void deprivedButton_Click(object sender, EventArgs e)
        {
            clothing = "Deprived";
            changeScreen();
        }
        #endregion

        public void changeScreen()
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            weaponScreen ws = new weaponScreen();
            f.Controls.Add(ws);
            ws.Location = new Point((f.Width - ws.Width) / 2, (f.Height - ws.Height) / 2);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            colorScreen cs = new colorScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
        }
    }
}
