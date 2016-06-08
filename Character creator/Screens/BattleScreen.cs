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
        // strings for attacks
        string attack1, attack2,attack3;

        private void attackTwoButton_Click(object sender, EventArgs e)
        {

        }

        private void attackThreeButton_Click(object sender, EventArgs e)
        {

        }

        private void attackOneButton_Click(object sender, EventArgs e)
        {
            //assigning values to what happens when you use your weapon based attack
            switch (reviewScreen.ch.weapon)
            {
                case "Axe":
                    playerEnergyBar.Value -= ranNum.Next(10, 16);
                    monsterHealthBar.Value -= ranNum.Next(15, 21);
                    break;
                case "Sword":
                    playerEnergyBar.Value -= ranNum.Next(6, 13);
                    monsterHealthBar.Value -= ranNum.Next(10, 15);
                    break;
                case "Dagger":
                    playerEnergyBar.Value -= ranNum.Next(3, 10);
                    monsterHealthBar.Value -= ranNum.Next(1, 7);
                    break;
                case "Staff":
                    playerEnergyBar.Value -= ranNum.Next(13, 20);
                    monsterHealthBar.Value -= ranNum.Next(18, 25);
                    break;
                case "Fist":
                    playerEnergyBar.Value -= ranNum.Next(5, 18);
                    monsterHealthBar.Value -= ranNum.Next(5, 18);
                    break;
                default:
                    break;
            }
        }

        private void BattleScreen_Load(object sender, EventArgs e)
        {
            //puts the image of your character into the picture box
            characterBox.Image = reviewScreen.ch.picture;
            #region Attack Choices
            //choosing a number for base attack
            attackNum = ranNum.Next(0, 62);
            // each attack will be different but there will be variety battle to battle
            if (attackNum >= 0 && attackNum <= 20)
            {
                //High energy high attack
                attack3 = "Body Slam";
            }
            else if (attackNum >= 21 && attackNum <= 40)
            {
                //low energy low attack
                attack3 = "Light attack";
            }
            else if (attackNum >= 41 && attackNum <= 59)
            {
                //gets away from battle if need be
                attack3 = "Run Away";
            }
            else if (attackNum >= 60)
            {
                //very rare but will instantly win battle
                attack3 = "Divine Intervention";
            }
            //attacks based on weapons
             switch (reviewScreen.ch.weapon)
            {
                case "Axe":
                    // high energy high attack
                    attack1 = "Heavy Swing";
                    break;
                case "Sword":
                    // less energy than axe but still moderate attack
                    attack1 = "Slash";
                    break;
                case "Dagger":
                    //can be very low energy with very low attack
                    attack1 = "Knife Throw";
                    break;
                case "Staff":
                    //very high on both energy and attack
                    attack1 = "Fireball";
                    break;
                case "Fist":
                    //very varying attack 
                    attack1 = "Sucker punch";
                    break;
                default:
                    break;
            }
            switch(reviewScreen.ch.clothes)
            {
                case "Knight":
                    //raises own health high drain on energy
                    attack2 = "Healing";
                    break;
                case "Deprived":
                    //low energy moderate attack with chance of monster fleeing
                    attack2 = "Stink attack";
                    break;
                case "Thief":
                    //low energy high attack
                    attack2 = "BackStab";
                    break;
                case "Mage":
                    //raises own energy but will drain a bit of health
                    attack2 = "Regeneration";
                    break;
                case "Peasant":
                    ///nothing really happens on some turns since oligarchs dont care about the peasnats
                   /// but might have big impact on monster 
                   /// Lots of energy being used though  
                    attack2 = "Economic Crisis";
                    break;
                default:
                    break;
            }
            #endregion
            //assiging a name to each button so player knows what their doing
            attackOneButton.Text = attack1;
            attackTwoButton.Text = attack2;
            attackThreeButton.Text = attack3;
        }
    }
}
