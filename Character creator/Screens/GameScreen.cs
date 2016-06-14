﻿using System;
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
        Boolean aArrowDown, dArrowDown, spaceArrowDown;
        List<Monsters> monsterList = new List<Monsters>();
        Random rand = new Random();
        Monsters m = new Monsters(0, 700, 300, 4, "1");
        string monsterType;
        int monsterStart;
        int totalScore;

        public GameScreen()
        {
            InitializeComponent();
            monsterList.Add(m);
            gameTimer.Enabled = true;
            // resumeButton.Visible = false;
            aArrowDown = dArrowDown = spaceArrowDown = false;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //characterBox.Image = weaponScreen.finalPic;
            this.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            PauseMenu pm = new PauseMenu();
            pm.Location = new Point((f.Width - pm.Width) / 2, (f.Height - pm.Height) / 2);
            f.Controls.Add(pm);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
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

        private void gameTimer_Tick(object sender, EventArgs e)

        {
            #region Character Movement
            if (aArrowDown == true)
            {
                reviewScreen.ch.move(reviewScreen.ch, "Left");
            }
            else if (dArrowDown == true)
            {
                reviewScreen.ch.move(reviewScreen.ch, "right");
            }
            #endregion

            #region Monster Movement
            foreach (Monsters m in monsterList)
            {
                if (reviewScreen.ch.x > m.x)
                {
                    m.move(m, "right");
                }
                else
                {
                    m.move(m, "left");
                }
            }
            #endregion

            #region Collision
            foreach (Monsters m in monsterList)
            {
                if (m.monsterCollision(m, reviewScreen.ch) == true)
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    BattleScreen bs = new BattleScreen();
                    bs.Location = new Point((f.Width - bs.Width) / 2, (f.Height - bs.Height) / 2);
                    f.Controls.Add(bs);
                    
                    
                    foreach (Monsters o in monsterList)
                    {
                        if (BattleScreen.win == true)
                        {
                            monsterType = Convert.ToString(rand.Next(1, 3));
                            monsterStart = rand.Next(0, 1);
                            if (monsterStart == 0)
                            {
                                Monsters n = new Monsters(0, 700, 300, 4, monsterType);
                            }
                            if (monsterStart == 1)
                            {
                                Monsters n = new Monsters(400, 700, 300, 4, monsterType);
                            }
                            monsterList.Add(m);
                            totalScore = totalScore + BattleScreen.scoreIncrease;
                        }
                        else
                        {
                            for (int i = 0; i < MainMenu.userList.Count(); i++)
                            {
                                if (MainMenu.userList[i].username == MainMenu.playerName)
                                {
                                    if (Convert.ToInt16(MainMenu.userList[i].score) > totalScore)
                                    {
                                        MainMenu.userList[i].score = Convert.ToString(totalScore);
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            characterImage.Location = new Point(reviewScreen.ch.x, reviewScreen.ch.y);
            monsterImage.Location = new Point(m.x, m.y);
        }

    }
}

