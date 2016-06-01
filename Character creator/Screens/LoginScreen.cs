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
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            usernameBox.MaxLength = 8;
            passwordBox.MaxLength = 8;
        }

        private void clickSignUpLabel_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;


            Form f = this.FindForm();
            f.Controls.Remove(this);
            signUpScreen sus = new signUpScreen();
            sus.Location = new Point((f.Width - sus.Width) / 2, (f.Height - sus.Height) / 2);
            f.Controls.Add(sus);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OldOrNewCharacter onc = new OldOrNewCharacter();
            onc.Location = new Point((f.Width - onc.Width) / 2, (f.Height - onc.Height) / 2);
            f.Controls.Add(onc);
        }
    }
}
