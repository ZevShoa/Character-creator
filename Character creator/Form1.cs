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
            NameScreen ns = new NameScreen();
            this.Controls.Add(ns);
            ns.Location = new Point((this.Width - ns.Width) / 2, (this.Height - ns.Height) / 2);
        }
    }
}
