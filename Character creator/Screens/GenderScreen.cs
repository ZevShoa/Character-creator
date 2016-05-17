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
            nameLabel.Text = NameScreen.name;
        } 
        private void maleButton_Click(object sender, EventArgs e)
        {
            gender = "male";
            nextScreen();
        }
        private void femaleButton_Click(object sender, EventArgs e)
        {
            gender = "female";
            nextScreen();
        }
        #region Mouse enter/leave
        private void femaleButton_MouseEnter(object sender, EventArgs e)
        {
            
            genderPicBox.Image = Properties.Resources.female;
        }

        private void femaleButton_MouseLeave(object sender, EventArgs e)
        {
            genderPicBox.Image = null;
        }
        private void maleButton_MouseEnter(object sender, EventArgs e)
        {
            genderPicBox.Image = Properties.Resources.male;
        }
        private void maleButton_MouseLeave(object sender, EventArgs e)
        {
            genderPicBox.Image = null;
        }
        #endregion
        public void nextScreen()
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            colorScreen cs = new colorScreen();
            f.Controls.Add(cs);
        }
    }
}
