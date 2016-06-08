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
        string gender = GenderScreen.gender;
        public static string color;
        public colorScreen()
        {
            InitializeComponent();
        }
      

        private void colorScreen_Load(object sender, EventArgs e)
        {
            // sets label to users name
            nameLabel.Text = NameScreen.name;   
        }
        //all of the code to make the pictures of the different colors and genders appear when mouse hovers over the 
        //buttons
        #region mouse enter/leave
        private void purpleButton_MouseEnter(object sender, EventArgs e)
        {
            switch(GenderScreen.gender)
            {
                case "female":
                    colorBox.Image = Properties.Resources.Female_Purple;
                    break;
                case "male":
                    colorBox.Image = Properties.Resources.Male_Purple;
                    break;
            }
        }

        private void purpleButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }

        private void yellowButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    colorBox.Image = Properties.Resources.Female_Yellow;
                    break;
                case "male":
                    colorBox.Image = Properties.Resources.Male_Yellow;
                    break;
            }
        }

        private void yellowButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }

        private void redButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    colorBox.Image = Properties.Resources.Female_Red;
                    break;
                case "male":
                    colorBox.Image = Properties.Resources.Male_Red;
                    break;
            }
        }

        private void redButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }

        private void greenButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    colorBox.Image = Properties.Resources.Female_Green;
                    break;
                case "male":
                    colorBox.Image = Properties.Resources.Male_Green;
                    break;
            }
        }

        private void greenButton_MouseLeave(object sender, EventArgs e)
        {
            colorBox.Image = null;
        }
        #endregion

        //saves colour choices and runs method to change screen
        #region button clicks
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
        #endregion
        public void changeScreen()
        {
            //goes to next screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            clothingScreen cs = new clothingScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //goes back a screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GenderScreen gs = new GenderScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }
    }
}
