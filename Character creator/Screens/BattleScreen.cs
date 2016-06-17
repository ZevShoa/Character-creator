using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Character_creator
{
    public partial class BattleScreen : UserControl
    {
        // strings for attacks
        string attack1, attack2, attack3;
        //random number generator used throughout
        Random ranNum = new Random();
        //all variables that are used thorough out 
        int attackNum;
        int stinkRan;
        int phraseNum;
        public static int scoreIncrease;
       public static bool win;
        //abusive comments
        string[] annoucerPhrases = {"That sucked", "Is that really the best you could do?", "Pathetic",
        "lol that was a joke right?", "You dirty swine, what are you doing?"/*Credit to Ben Fortin*/, "WhAt ThE F*Ck ArE yOu DoInG"};
        public BattleScreen()
        {
            InitializeComponent();
        }
        
        #region button clicks
        private void attackTwoButton_Click(object sender, EventArgs e)
        {
            //attacks based on class
            switch(attack2)
            {
                case "Healing":
                    if (playerHealthBar.Value > 100)
                    {
                        playerHealthBar.Value += ranNum.Next(1, 20);
                    }
                    break;
                case "Stink Attack":
                    stinkRan = ranNum.Next(0, 11);
                    if (stinkRan >= 10)
                    {
                        win = true;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        GameScreen gs = new GameScreen();
                        f.Controls.Add(gs);
                        gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                        
                    }
                    else
                    {
                        playerEnergyBar.Value -= ranNum.Next(2, 12);
                        monsterHealthBar.Value -= ranNum.Next(1, 15);
                    }
                    break;
                case "BackStab":
                    playerEnergyBar.Value -= ranNum.Next(20, 30);
                    monsterHealthBar.Value -= ranNum.Next(20, 35);
                    break;
                case "Regeneration":
                    playerEnergyBar.Value += ranNum.Next(5, 13);
                    playerHealthBar.Value -= ranNum.Next(1, 5);
                     break;
                case "Economic Crisis":
                    playerEnergyBar.Value -= ranNum.Next(15, 35);
                    monsterHealthBar.Value -= ranNum.Next(3, 40);
                    break;

            }
            //calling monster to attack
            monsterTurn();
        }

        private void attackThreeButton_Click(object sender, EventArgs e)
        {
            //random attacks that anyone could have in any fight
            switch (attack3)
            {
                case "Body Slam":
                    playerEnergyBar.Value -= ranNum.Next(20, 31);
                    monsterHealthBar.Value -= ranNum.Next(1, 36);
                    break;
                case "Light Attack":
                    playerEnergyBar.Value -= ranNum.Next(2, 11);
                    monsterHealthBar.Value -= ranNum.Next(5, 15);
                    break;
                case "Gentle Poke":
                    playerEnergyBar.Value -= ranNum.Next(3, 6);
                    monsterHealthBar.Value -= ranNum.Next(0, 6);
                    break;
                case "Divine Intervention":
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    GameScreen gs = new GameScreen();
                    f.Controls.Add(gs);
                    gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                    //ALSO NEED CODE TO DELTE MONSTER
                    break;                
            }
            //calling monster to attack
            monsterTurn();
        }
        private void attackOneButton_Click(object sender, EventArgs e)
        {
            //assigning values to what happens when you use your weapon based attack
            switch (attack1)
            {
                case "Heavy Swing":
                    playerEnergyBar.Value -= ranNum.Next(10, 16);
                    monsterHealthBar.Value -= ranNum.Next(15, 21);
                    break;
                case "Slash":
                    playerEnergyBar.Value -= ranNum.Next(6, 13);
                    monsterHealthBar.Value -= ranNum.Next(10, 15);
                    break;
                case "Knife Throw":
                    playerEnergyBar.Value -= ranNum.Next(3, 10);
                    monsterHealthBar.Value -= ranNum.Next(1, 7);
                    break;
                case "Fireball":
                    playerEnergyBar.Value -= ranNum.Next(13, 20);
                    monsterHealthBar.Value -= ranNum.Next(18, 25);
                    break;
                case "Sucker punch":
                    playerEnergyBar.Value -= ranNum.Next(5, 18);
                    monsterHealthBar.Value -= ranNum.Next(5, 18);
                    break;
                default:
                    break;
            }
            //calling monster to attack
            monsterTurn();
        }
        #endregion
        private void BattleScreen_Load(object sender, EventArgs e)
        {
            announcerLabel.Text = reviewScreen.ch.name + "'s Turn";
            //puts the image of your character into the picture box
            characterBox.Image = reviewScreen.ch.picture;
            if (GameScreen.monsterList[0].type == 0)
            {
                monsterBox.Image = Properties.Resources.monstereasy;
            }
            else if (GameScreen.monsterList[0].type == 1)
            {
                monsterBox.Image = Properties.Resources.monsterMedium;
            }
            else if (GameScreen.monsterList[0].type == 2)
            {
                monsterBox.Image = Properties.Resources.monsterHard;
            }

            #region Attack Choices
            //choosing a number for base attack
            attackNum = ranNum.Next(0, 62);
            // each attack will be different but there will be variety battle to battle
            if (attackNum >= 0 && attackNum <= 20)
            {
                //High energy varying attack
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
                attack3 = "Gentle Poke";
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
                    attack2 = "Stink Attack";
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
                    ///nothing really happens on some turns since oligarchs don't care about the peasants
                   /// but might have big impact on monster 
                   /// Lots of energy being used though  
                    attack2 = "Economic Crisis";
                    break;
                default:
                    break;
            }
            #endregion
            //assigning a name to each button so player knows what their doing
            attackOneButton.Text = attack1;
            attackTwoButton.Text = attack2;
            attackThreeButton.Text = attack3;
        }

        public void monsterTurn()
        {
            //makes it so you cant hit the monsters
            attackOneButton.Enabled = false;
            attackTwoButton.Enabled = false;
            attackThreeButton.Enabled = false;
            if(monsterHealthBar.Value >= 0)
            {
                //adds health and energy to score
                scoreIncrease = playerEnergyBar.Value + playerHealthBar.Value;
                //so other screens can know the outcome of the battle
                win = true;
                //changes screens 
                announcerLabel.Text = "The Monster Is Vanquished";
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                
            }
            else
            {
                foreach (Monsters m in GameScreen.monsterList)
                {
                    //takes a certain amount off the players health
                    switch (m.type)
                    {
                        case 0:
                            playerHealthBar.Value -= ranNum.Next(1, 20);
                            break;
                        case 1:
                            playerHealthBar.Value -= ranNum.Next(20, 40);
                            break;
                        case 2:
                            playerHealthBar.Value -= ranNum.Next(20, 50);
                            break;
                        default:
                            break;
                    }
                }



            }
        }

        public void playerTurn()
        {
            if (playerHealthBar.Value >= 0 || playerEnergyBar.Value >= 0)
            {
                //an abusive comment about the user 
                phraseNum = ranNum.Next(1, 7);
                announcerLabel.Text = annoucerPhrases[phraseNum];
                //so other screens can know the outcome of the battle
                win = false;
                //adds health and energy to score but takes away how much health the monster had left
                scoreIncrease = playerHealthBar.Value + playerEnergyBar.Value - monsterHealthBar.Value;
                //goes back to battle screen to calculate score and then goes to fail screen from there
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            }
            else
            {
                //re-enabling buttons for your attack
                attackOneButton.Enabled = true;
                attackTwoButton.Enabled = true;
                attackThreeButton.Enabled = true;
                //a message prompts player to go
                announcerLabel.Text = reviewScreen.ch.name + "'s Turn";
            }
        
        }
    }
}
