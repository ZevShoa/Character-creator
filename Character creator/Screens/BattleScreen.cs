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
using System.Media;

namespace Character_creator
{
    public partial class BattleScreen : UserControl
    {
        //Battle Sounds
        SoundPlayer battleSound = new SoundPlayer(Properties.Resources.No_mercy_Hipis_1227409429);

        // strings for attacks
        string attack1, attack2, attack3;
        bool attackMade = false;
        //random number generator used throughout
        Random ranNum = new Random();
        //all variables that are used thorough out 
        public static int humanHealth = 100;
        public static int humanEnergy = 100;
        int monsterHealth = 100;
        int attackNum;
        int stinkRan;
        int phraseNum;
        public static int scoreIncrease;
       public static bool win;
        bool characterTurn = true;
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
            attackMade = true;
            //attacks based on class
            switch(attack2)
            {
                case "Healing":
                    if (humanHealth < 80)
                    {
                        humanHealth += ranNum.Next(1, 20);
                    }
                    if(humanHealth <100 && humanHealth > 80)
                    {
                        humanHealth = 100;
                    }
                    break;
                case "Stink Attack":
                    stinkRan = ranNum.Next(0, 11);
                    if (stinkRan >= 10)
                    {
                        win = true;
                        monsterHealth = 0;
                        
                    }
                    else
                    {
                       humanEnergy -= ranNum.Next(2, 12);
                        monsterHealth -= ranNum.Next(1, 15);
                    }
                    break;
                case "BackStab":
                   humanEnergy -= ranNum.Next(20, 30);
                    monsterHealth -= ranNum.Next(20, 35);
                    break;
                case "Regeneration":
                    humanEnergy += ranNum.Next(5, 13);
                    humanHealth -= ranNum.Next(1, 5);
                     break;
                case "Economic Crisis":
                   humanEnergy -= ranNum.Next(15, 35);
                    monsterHealth -= ranNum.Next(3, 40);
                    break;

            }
        }

        private void attackThreeButton_Click(object sender, EventArgs e)
        {
            attackMade = true;
            //random attacks that anyone could have in any fight
            switch (attack3)
            {
                case "Body Slam":
                    humanEnergy -= ranNum.Next(20, 31);
                    monsterHealth -= ranNum.Next(1, 36);
                    break;
                case "Light Attack":
                    humanEnergy -= ranNum.Next(2, 11);
                    monsterHealth -= ranNum.Next(5, 15);
                    break;
                case "Gentle Poke":
                   humanEnergy -= ranNum.Next(3, 6);
                    monsterHealth -= ranNum.Next(1, 6);
                    break;
                case "Divine Intervention":
                    monsterHealth = 0;
                    break;                
            }
        }
        private void attackOneButton_Click(object sender, EventArgs e)
        {
            attackMade = true;
            //assigning values to what happens when you use your weapon based attack
            switch (attack1)
            {
                case "Heavy Swing":
                    humanEnergy -= ranNum.Next(10, 16);
                    monsterHealth -= ranNum.Next(15, 21);
                    break;
                case "Slash":
                    humanEnergy -= ranNum.Next(6, 13);
                    monsterHealth -= ranNum.Next(10, 15);
                    break;
                case "Knife Throw":
                    humanEnergy -= ranNum.Next(3, 10);
                    monsterHealth -= ranNum.Next(1, 7);
                    break;
                case "Fireball":
                   humanEnergy -= ranNum.Next(13, 20);
                    monsterHealth -= ranNum.Next(18, 25);
                    break;
                case "Sucker punch":
                    humanEnergy -= ranNum.Next(5, 18);
                    monsterHealth -= ranNum.Next(5, 18);
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void BattleScreen_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = GameScreen.background[GameScreen.position];
            announcerLabel.Text = reviewScreen.ch.name + "'s Turn";
            //puts the image of your character into the picture box
            characterBox.Image = reviewScreen.ch.picture;
            foreach (Monsters m in GameScreen.monsterList)
            {
                monsterBox.Image = m.monsterImages[m.type];
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
                case "Rogue":
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
            battleTimer.Enabled = true;
        }

        private void battleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                playerHealthBar.Value = humanHealth;
                playerHealthLabel.Text = Convert.ToString(humanHealth) + "%";
                playerEnergyBar.Value = humanEnergy;
                playerEnergyLabel.Text = Convert.ToString(humanEnergy) + "%";
                monsterHealthBar.Value = monsterHealth;
                monsterHealthLabel.Text = Convert.ToString(monsterHealth) + "%";
            }
            catch
            {
                playerTurn();
                monsterTurn();
            }

           if (characterTurn == true)
            {
                if (attackMade == true)
                {
                    playerTurn();
                    characterTurn = false;
                }
            }
            else if (characterTurn == false)
            {
                monsterTurn();
                characterTurn = true;
                attackMade = false;
            }
        }

        public void monsterTurn()
        {
            announcerLabel.Text = "Enemy's Turn";
            Refresh();
            //makes it so you cant hit the monsters
            attackOneButton.Enabled = false;
            attackTwoButton.Enabled = false;
            attackThreeButton.Enabled = false;
            battleSound.Play();
            Thread.Sleep(1000);

                //takes a certain amount off the players health
                switch (GameScreen.monsterList[0].type)
                {
                    case 0:
                        humanHealth -= ranNum.Next(1, 20);
                        break;
                    case 1:
                        humanHealth -= ranNum.Next(20, 40);
                        break;
                    case 2:
                        humanHealth -= ranNum.Next(20, 50);
                        break;
                    default:
                        break;
                }
            Thread.Sleep(1000);

            if (humanHealth <= 0 || humanEnergy <= 0)
            {
                //adds health and energy to score and subtracts the health of the monster, but doesnt allow
                //the increase to be negative
                if (humanEnergy + humanHealth - monsterHealth > 0)
                {
                    scoreIncrease = humanEnergy + humanHealth - monsterHealth;
                }
                else
                {
                    scoreIncrease = 0;
                }
                GameScreen.totalScore = GameScreen.totalScore + scoreIncrease;
                //an abusive comment about the user 
                phraseNum = ranNum.Next(0, 6);
                announcerLabel.Text = annoucerPhrases[phraseNum];
                announcerLabel.Refresh();
                Thread.Sleep(2000);
                battleTimer.Enabled = false;
       
                //so other screens can know the outcome of the battle
                win = false;
                GameScreen.totalScore = GameScreen.totalScore + scoreIncrease;
                //goes back to battle screen to calculate score and then goes to fail screen from there
                Form f = this.FindForm();
                f.Controls.Remove(this);
                failScreen fs = new failScreen();
                f.Controls.Add(fs);
                fs.Location = new Point((f.Width - fs.Width) / 2, (f.Height - fs.Height) / 2);
            }
            else
            {
                //re-enabling buttons for your attack
                attackOneButton.Enabled = true;
                attackTwoButton.Enabled = true;
                attackThreeButton.Enabled = true;
                //a message prompts player to go
                announcerLabel.Text = reviewScreen.ch.name + "'s Turn";
                announcerLabel.Refresh();
            }
        }

        public void playerTurn()
        {
            if (monsterHealth <= 0)
            {   //adds health and energy to score
                scoreIncrease = humanEnergy + humanHealth;
                //so other screens can know the outcome of the battle
                win = true;
                announcerLabel.Text = "The Monster Is Vanquished";
                announcerLabel.Refresh();
                Thread.Sleep(2000);

                //changes screens 
                GameScreen.totalScore = GameScreen.totalScore + scoreIncrease;
                battleTimer.Enabled = false;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GiftScreen gs = new GiftScreen();
                f.Controls.Add(gs);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            }
        
            if(humanEnergy <= 0)
            {
                //adds health and energy to score and subtracts the health of the monster, but doesnt allow
                //the increase to be negative
                if (humanEnergy + humanHealth - monsterHealth > 0)
                {
                    scoreIncrease = humanEnergy + humanHealth - monsterHealth;
                }
                else
                {
                    scoreIncrease = 0;
                }
                GameScreen.totalScore = GameScreen.totalScore + scoreIncrease;
                //an abusive comment about the user 
                phraseNum = ranNum.Next(0, 6);
                announcerLabel.Text = annoucerPhrases[phraseNum];
                Thread.Sleep(2000);
                Refresh();
                battleTimer.Enabled = false;
               
                //so other screens can know the outcome of the battle
                win = false;

                //goes back to battle screen to calculate score and then goes to fail screen from there
                Form f = this.FindForm();
                f.Controls.Remove(this);
                failScreen gs = new failScreen();
                f.Controls.Add(gs);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            }
        }
    }
}
