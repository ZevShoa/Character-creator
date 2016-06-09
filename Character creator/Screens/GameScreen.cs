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
        Boolean aArrowDown, dArrowDown, spaceArrowDown;
        
        public GameScreen()
        {
            InitializeComponent();
          
            gameTimer.Enabled = true;
            resumeButton.Visible = false;
          


        }
       
        private void GameScreen_Load(object sender, EventArgs e)
        {
            characterBox.Image = weaponScreen.finalPic;
            this.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();

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
            if (aArrowDown == true)
            {
                reviewScreen.ch.move(reviewScreen.ch, "Left");
                
            }
            else if (dArrowDown == true)
            {
                reviewScreen.ch.move(reviewScreen.ch, "Right");
            }
            Refresh();
        }

    }
}
