using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //signUpScreen sus = new signUpScreen();
            //this.Controls.Add(sus);
            //sus.Location = new Point((this.Width - sus.Width) / 2, (this.Height - sus.Height) / 2);
        }
    }
}
