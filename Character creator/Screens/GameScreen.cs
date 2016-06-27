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
    public partial class GameScreen : UserControl
    {
        //creates all the variables needed for the game
        int monsterStart;
        public static Image[] monsterImages;
        Boolean aArrowDown, dArrowDown, spaceArrowDown, changeDirectionRight, changeDirectionLeft, start;
        public static Image[] background;
        public static int battleNum = 0;
        public static Monsters m;
        string movement = "left";
        public static int position = 0;
        Random rand = new Random();
        public static bool battleOver = false;
        public static int totalScore;
        public static bool gamePlayed = false;
        int counter = 0;

        public GameScreen()
        {
            InitializeComponent();
            //creates the lists of monster and background images
            monsterImages = new Image[] { Properties.Resources.Monster_1, Properties.Resources.Monster_2, Properties.Resources.Monster_3 };
            background = new Image[] { Properties.Resources.WaveLevel, Properties.Resources.GameBackground, Properties.Resources.jungleBattle, Properties.Resources.OptionBG };
            aArrowDown = dArrowDown = spaceArrowDown = false;
            changeDirectionRight = true;
            changeDirectionLeft = true;
            start = true;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //sets the monster at either the left or the right of the screen and starts gametimer 
            monsterStart = rand.Next(0, 2);
            if (monsterStart == 0)
            {
                GameScreen.m = new Monsters(-300, 400, 300, 4, rand.Next(0, 3));
            }
            if (monsterStart == 1)
            {
                GameScreen.m = new Monsters(900, 400, 300, 4, rand.Next(0, 3));
            }
            this.Focus();
            gameTimer.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //goes to pause menu
            gameTimer.Stop();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            PauseMenu pm = new PauseMenu();
            pm.Location = new Point((f.Width - pm.Width) / 2, (f.Height - pm.Height) / 2);
            f.Controls.Add(pm);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //see if a key is pressed
            switch (e.KeyCode)
            {
                case Keys.A:
                    aArrowDown = true;
                    break;
                case Keys.D:
                    dArrowDown = true;
                    break;
                case Keys.Space:
                    spaceArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //sees if a key is not pressed
            switch (e.KeyCode)
            {
                case Keys.A:
                    aArrowDown = false;
                    break;
                case Keys.D:
                    dArrowDown = false;
                    break;
                case Keys.Space:
                    spaceArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// opens the pause screeen and pauses the game timer
        /// </summary>
        public void pauseMethod()
        {
            gameTimer.Stop();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            PauseMenu pm = new PauseMenu();
            pm.Location = new Point((f.Width - pm.Width) / 2, (f.Height - pm.Height) / 2);
            f.Controls.Add(pm);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //adds one to the counter, so energy can be removed and health added
            counter++;

            //displays the players health and energy
            charHealthLabel.Text = "Health: " + Convert.ToString(BattleScreen.humanHealth) + "%";
            charEnergyLabel.Text = "Energy: " + Convert.ToString(BattleScreen.humanEnergy) + "%";
            charHealthBar.Value = BattleScreen.humanHealth;
            charEnergyBar.Value = BattleScreen.humanEnergy;

            //if the player presses space the pause menu opens
            if (spaceArrowDown == true)
            {
                pauseMethod();
            }
            //moving character left and right
            #region Character Movement
            if (aArrowDown == true)
            {
                if (reviewScreen.ch.x > 0)
                {
                    reviewScreen.ch.move(reviewScreen.ch, "Left");
                }
                else if (reviewScreen.ch.x <= 0)
                {
                    reviewScreen.ch.x = this.Width - 200;
                    m.x = m.x + this.Width;
                    if (position > 0)
                    {
                        position--;
                    }
                    else
                    {
                        position = 3;
                    }

                }
                movement = "left";
                changeDirectionRight = true;
            }
            else if (dArrowDown == true)
            {
                if (reviewScreen.ch.x < this.Width - 200)
                {
                    reviewScreen.ch.move(reviewScreen.ch, "right");
                }
                else if (reviewScreen.ch.x >= this.Width - 200)
                {
                    reviewScreen.ch.x = 0;
                    m.x = m.x - this.Width;
                    if (position < 2)
                    {
                        position++;
                    }
                    else
                    {
                        position = 0;
                    }

                }
                movement = "right";
                changeDirectionLeft = true;
            }
            #endregion

            //moving monster to chase the player
            #region Monster Movement
            if (reviewScreen.ch.x > m.x)
            {
                m.move(m, "right");
            }
            else
            {
                m.move(m, "left");
            }
            #endregion

            #region Collision
            //if the monster and character collide the battlescreen opens
            if (m.monsterCollision(m, reviewScreen.ch) == true)
            {
                battleMove();
            }
            #endregion

            #region Deplete Energy Replenish Health
            //ever 30 sec will take away 1 energy and add 1 health
            if (counter / 10 >= 30)
            {
                if (BattleScreen.humanEnergy > 0)
                {
                    BattleScreen.humanEnergy--;
                }
                else if (BattleScreen.humanEnergy <= 0)
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    failScreen fs = new failScreen();
                    f.Controls.Add(fs);
                    fs.Location = new Point((f.Width - fs.Width) / 2, (f.Height - fs.Height) / 2);
                }
                if (BattleScreen.humanHealth < 100)
                {
                    BattleScreen.humanEnergy++;
                }
                counter = 0;
            }
            #endregion

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draws the images, labels, and progress bars on the screen at the desired location, and facing the desired direction
            this.BackgroundImage = background[position];
            if (movement == "right")
            {
                if (changeDirectionRight == true)
                {
                    reviewScreen.ch.picture.RotateFlip(RotateFlipType.Rotate180FlipY);
                    changeDirectionRight = false;
                }
                start = false;
            }
            else if (movement == "left")
            {
                if (changeDirectionLeft == true && start == false)
                {
                    reviewScreen.ch.picture.RotateFlip(RotateFlipType.Rotate180FlipY);
                    changeDirectionLeft = false;
                }
            }

            e.Graphics.DrawImage(reviewScreen.ch.picture, reviewScreen.ch.x, reviewScreen.ch.y, 200, 300);

            ((Bitmap)reviewScreen.ch.picture).MakeTransparent(((Bitmap)reviewScreen.ch.picture).GetPixel(1, 1));
            this.BackColor = System.Drawing.Color.Transparent;
            e.Graphics.DrawImage(monsterImages[m.type], m.x, m.y, 150, 150);
            charHealthLabel.Location = new Point(reviewScreen.ch.x + 50, 180);
            charEnergyLabel.Location = new Point(reviewScreen.ch.x + 50, 200);
            charHealthBar.Location = new Point(reviewScreen.ch.x + 50 + 80, 180);
            charEnergyBar.Location = new Point(reviewScreen.ch.x + 50 + 80, 200);

        }

        /// <summary>
        /// Opens battle screen and pauses timer
        /// </summary>
        public void battleMove()
        {
            gameTimer.Stop();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            BattleScreen bs = new BattleScreen();
            bs.Location = new Point((f.Width - bs.Width) / 2, (f.Height - bs.Height) / 2);
            f.Controls.Add(bs);
        }

    }
}