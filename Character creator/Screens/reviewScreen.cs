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
    public partial class reviewScreen : UserControl
    {
        public reviewScreen()
        {
            InitializeComponent();
        }
        Character ch = new Character(NameScreen.name, clothingScreen.clothing, weaponScreen.weapon, GenderScreen.gender, colorScreen.color, statScreen.healthStat, statScreen.energyStat);
        private void reviewScreen_Load(object sender, EventArgs e)
        {
            label1.Text = ch.name;
        }
    }
}
