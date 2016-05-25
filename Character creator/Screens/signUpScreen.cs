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
    public partial class signUpScreen : UserControl
    {
        public signUpScreen()
        {
            InitializeComponent();
        }

        private void signUpScreen_Load(object sender, EventArgs e)
        {
            userTextBox.MaxLength = 8;
            passwordTextBox.MaxLength = 8;
        }
    }
}
