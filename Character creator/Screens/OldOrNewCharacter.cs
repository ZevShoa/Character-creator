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
    public partial class OldOrNewCharacter : UserControl
    {
        public OldOrNewCharacter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newCharacterButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            NameScreen ns = new NameScreen();
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);
        }

        private void selectOldCharacterButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            f.Controls.Add(rs);
        }
    }
}
