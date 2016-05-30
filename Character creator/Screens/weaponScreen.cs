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
        #region buttons clicks
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
        #endregion

        public void changeScreen()
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            statScreen ss = new statScreen();
            f.Controls.Add(ss);
            ss.Location = new Point((f.Width - ss.Width) / 2, (f.Height - ss.Height) / 2);
        }

        private void weaponScreen_Load(object sender, EventArgs e)
        {
            nameLabel.Text = NameScreen.name;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            clothingScreen cs = new clothingScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
        }

        private void swordButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    switch (colorScreen.color)
                    {
                        case "purple":

                            break;
                        case "yellow":

                            break;
                        case "red":

                            break;
                        case "green":

                            break;
                    }
                    break;
                case "male":
                    switch (colorScreen.color)
                    {
                        case "purple":

                            break;
                        case "yellow":

                            break;
                        case "red":

                            break;
                        case "green":

                            break;
                        
                    }
                    
            }
        }

        private void staffButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void fistButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void axeButtton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void daggerButton_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
