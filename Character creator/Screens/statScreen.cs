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
    public partial class statScreen : UserControl
    {
        public statScreen()
        {
            InitializeComponent();
        }

        private void statScreen_Load(object sender, EventArgs e)
        {
            nameLabel.Text = NameScreen.name;
        }
    }
}
