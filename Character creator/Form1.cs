using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Character_creator
{
    public partial class Form1 : Form
    {
        // Creates the Sound Player
        public static SoundPlayer player = new SoundPlayer(Properties.Resources.DARK__Video_Game____Main_Theme_Music);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sounds
            player.PlayLooping();

            //opens how to play form
            Form f = this.FindForm();
            f.Controls.Remove(this);
            BackStory mm = new BackStory();
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
        }
    }
}
