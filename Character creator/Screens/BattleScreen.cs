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
    public partial class BattleScreen : UserControl
    {
        Random ranNum = new Random();
        int attackNum;

        public BattleScreen()
        {
            InitializeComponent();
        }
        string attack1, attack2,attack3;
        private void BattleScreen_Load(object sender, EventArgs e)
        {
            //attackNum = 
            //characterBox.Image = reviewScreen.ch.picture;
            // switch (reviewScreen.ch.weapon)
            //{
            //    case "Axe":
            //        attack1 = "Heavy Swing";
            //        break;
            //    case "Sword":
            //        attack1 = "Slash";
            //        break;
            //    case "Dagger":
            //        attack1 = "Knife Throw";
            //        break;
            //    case "Staff":
            //        attack1 = "Fireball";
            //        break;
            //    case "Fist":
            //        attack1 = "Sucker punch";
            //        break;
            //    default:
             //       break;
            }
            //switch(reviewScreen.ch.clothes)
            //{
            //    case "Knight":
            //        attack2 = "Healing";
            //        break;
            //    case "Deprived":
            //        attack2 = "Stink attack";
            //        break;
            //    case "Thief":
            //        attack2 = "BackStab";
            //        break;
            //    case "Mage":
            //        attack2 = "Regeneration";
            //        break;
            //    case "Peasant":
            //        attack2 = "Economic Crisis";
            //        break;
            //    default:
            //        break;
            //}

        //}
    }
}
