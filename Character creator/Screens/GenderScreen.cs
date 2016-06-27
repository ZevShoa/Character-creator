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
    public partial class GenderScreen : UserControl
    {
        public static string gender;

        public GenderScreen()
        {
            InitializeComponent();
        }

        private void GenderScreen_Load(object sender, EventArgs e)
        {
            //sets the label to the users name
            nameLabel.Text = NameScreen.name;
        }
        private void maleButton_Click(object sender, EventArgs e)
        {
            //sets the variable of gender to male and calls method to move to next screen
            gender = "Male";
            nextScreen();
        }
        private void femaleButton_Click(object sender, EventArgs e)
        {
            //sets the variable of gender to female and calls method to move to next screen
            gender = "Female";
            nextScreen();
        }
        #region Mouse enter/leave
        private void femaleButton_MouseEnter(object sender, EventArgs e)
        {
            //when mouse hovers over button the picture box will show sample of female
            genderPicBox.Image = Properties.Resources.Female_Transparent;
        }

        private void femaleButton_MouseLeave(object sender, EventArgs e)
        {
            //gets rid of picture
            genderPicBox.Image = null;
        }
        private void maleButton_MouseEnter(object sender, EventArgs e)
        {
            //when mouse hovers over button the picture box will show sample of male
            genderPicBox.Image = Properties.Resources.Male_Transparent;
        }
        private void maleButton_MouseLeave(object sender, EventArgs e)
        {
            //gets rid of picture
            genderPicBox.Image = null;
        }
        #endregion
        public void nextScreen()
        {
            //moves to next screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            colorScreen cs = new colorScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //moves back a screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            NameScreen ns = new NameScreen();
            f.Controls.Add(ns);
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);

        }
    }
}
