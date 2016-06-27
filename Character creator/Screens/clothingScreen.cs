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
    public partial class clothingScreen : UserControl
    {
        public static string clothing;
        public clothingScreen()
        {
            InitializeComponent();
        }

        private void clothingScreen_Load(object sender, EventArgs e)
        {
            //gives label the users name
            nameLabel.Text = NameScreen.name;
        }
        //has many switch statements to show an image in the picture box when mouse hovers over the button
        #region Mouse Enter/Leave
        private void knightButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.femalePurpleKnight;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.femaleYellowKnight;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.femaleRedKnight;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.femaleGreenKnight;
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.malePurpleKnight;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.maleYellowKnight;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.maleRedKnight;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.maleGreenKnight;
                            break;
                    }

                    break;
            }
        }

        private void knightButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void peasentButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.femalePurplePeasant;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.femaleYellowPeasant;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.femaleRedPeasant;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.femaleGreenPeasant;
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.malePurplePeasant;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.maleYellowPeasant;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.maleRedPeasant;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.maleGreenPeasant;
                            break;
                    }

                    break;
            }
        }

        private void peasentButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void mageButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.femalePurpleMage;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.femaleYellowMage;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.femaleRedMage;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.femaleGreenMage;
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.malePurpleMage;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.maleYellowMage;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.maleRedMage;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.maleGreenMage;
                            break;
                    }

                    break;
            }
        }

        private void mageButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void rogueButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.femalePurpleThief;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.femaleYellowThief;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.femaleRedThief;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.femaleGreenThief;
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.malePurpleThief;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.maleYellowThief;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.maleRedThief;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.maleGreenThief;
                            break;
                    }

                    break;
            }
        }

        private void rogueButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }

        private void deprivedButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.femalePurpleDeprived;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.femaleYellowDeprived;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.femaleRedDeprived;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.femaleGreenDeprived;
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            clothingBox.Image = Properties.Resources.malePurpleDeprived;
                            break;
                        case "Yellow":
                            clothingBox.Image = Properties.Resources.maleYellowDeprived;
                            break;
                        case "Red":
                            clothingBox.Image = Properties.Resources.maleRedDeprived;
                            break;
                        case "Green":
                            clothingBox.Image = Properties.Resources.maleGreenDeprived;
                            break;
                    }

                    break;
            }
        }

        private void deprivedButton_MouseLeave(object sender, EventArgs e)
        {
            clothingBox.Image = null;
        }
        #endregion
        // saves clothing choice and runs method to change screen
        #region Buttons Clicks
        private void knightButton_Click(object sender, EventArgs e)
        {
            clothing = "Knight";
            changeScreen();
        }

        private void peasentButton_Click(object sender, EventArgs e)
        {
            clothing = "Peasant";
            changeScreen();
        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            clothing = "Mage";
            changeScreen();
        }

        private void rogueButton_Click(object sender, EventArgs e)
        {
            clothing = "Rogue";
            changeScreen();
        }

        private void deprivedButton_Click(object sender, EventArgs e)
        {
            clothing = "Deprived";
            changeScreen();
        }
        #endregion

        public void changeScreen()
        {
            //changes screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            weaponScreen ws = new weaponScreen();
            f.Controls.Add(ws);
            ws.Location = new Point((f.Width - ws.Width) / 2, (f.Height - ws.Height) / 2);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //goes back a screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            colorScreen cs = new colorScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
        }
    }
}
