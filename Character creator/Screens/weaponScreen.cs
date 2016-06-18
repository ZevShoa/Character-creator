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
    public partial class weaponScreen : UserControl
    {
        public static  string weapon;
        public static Image finalPic;
        public weaponScreen()
        {
            InitializeComponent();
        }

        public void changeScreen()
        {
            //go to review screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            reviewScreen rs = new reviewScreen();
            f.Controls.Add(rs);
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
        }

        private void weaponScreen_Load(object sender, EventArgs e)
        {
            //the name of the user is loaded
            nameLabel.Text = NameScreen.name;           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // go back a screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            clothingScreen cs = new clothingScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
        }
        //shows all the different weapons in the picture box
        #region Button enter/leave
        private void swordButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femalePurpleKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femalePurpleMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femalePurplePeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femalePurpleDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femalePurpleThiefSword;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleYellowKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleYellowMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleYellowPeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleYellowDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleYellowThiefSword;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleRedKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleRedMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleRedPeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleRedDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleRedThiefSword;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleGreenKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleGreenMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleGreenPeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleGreenDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleGreenThiefSword;
                                    break;
                            }
                            break;
                    }
                    break;
                case "male":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.malePurpleKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.malePurpleMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.malePurplePeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.malePurpleDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.malePurpleThiefSword;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleYellowKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleYellowMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleYellowPeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleYellowDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleYellowThiefSword;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleRedKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleRedMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleRedPeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleRedDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleRedTheifSword;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleGreenKnightSword;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleGreenMageSword;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleGreenPeasantSword;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleGreenDeprivedSword;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleGreenThiefSword;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void staffButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femalePurpleKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femalePurpleMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femalePurplePeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femalePurpleDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femalePurpleThiefStaff;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleYellowKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleYellowMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleYellowPeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleYellowDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleYellowThiefStaff;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleRedKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleRedMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleRedPeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleRedDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleRedThiefStaff;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleGreenKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleGreenMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleGreenPeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleGreenDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleGreenThiefStaff;
                                    break;
                            }
                            break;
                    }
                    break;
                case "male":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.malePurpleKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.malePurpleMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.malePurplePeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.malePurpleDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.malePurpleThiefStaff;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleYellowKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleYellowMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleYellowPeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleYellowDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleYellowThiefStaff;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleRedKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleRedMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleRedPeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleRedDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleRedTheifStaff;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleGreenKnightStaff;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleGreenMageStaff;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleGreenPeasantStaff;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleGreenDeprivedStaff;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleGreenThiefStaff;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void fistButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femalePurpleKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femalePurpleMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femalePurplePeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femalePurpleDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femalePurpleThiefFist;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleYellowKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleYellowMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleYellowPeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleYellowDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleYellowThiefFist;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleRedKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleRedMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleRedPeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleRedDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleRedThiefFist;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleGreenKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleGreenMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleGreenPeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleGreenDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleGreenThiefFist;
                                    break;
                            }
                            break;
                    }
                    break;
                case "male":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.malePurpleKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.malePurpleMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.malePurplePeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.malePurpleDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.malePurpleThiefFist;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleYellowKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleYellowMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleYellowPeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleYellowDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleYellowThiefFist;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleRedKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleRedMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleRedPeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleRedDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleRedTheifFist;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleGreenKnightFist;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleGreenMageFist;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleGreenPeasantFist;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleGreenDeprivedFist;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleGreenThiefFist;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void axeButtton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femalePurpleKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femalePurpleMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femalePurplePeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femalePurpleDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femalePurpleThiefAxe;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleYellowKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleYellowMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleYellowPeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleYellowDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleYellowThiefAxe;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleRedKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleRedMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleRedPeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleRedDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleRedThiefAxe;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleGreenKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleGreenMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleGreenPeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleGreenDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleGreenThiefAxe;
                                    break;
                            }
                            break;
                    }
                    break;
                case "male":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.malePurpleKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.malePurpleMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.malePurplePeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.malePurpleDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.malePurpleThiefAxe;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleYellowKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleYellowMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleYellowPeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleYellowDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleYellowThiefAxe;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleRedKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleRedMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleRedPeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleRedDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleRedTheifAxe;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleGreenKnightAxe;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleGreenMageAxe;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleGreenPeasantAxe;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleGreenDeprivedAxe;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleGreenThiefAxe;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void daggerButton_MouseEnter(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "female":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femalePurpleKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femalePurpleMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femalePurplePeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femalePurpleDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femalePurpleThiefDagger;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleYellowKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleYellowMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleYellowPeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleYellowDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleYellowThiefDagger;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleRedKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleRedMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleRedPeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleRedDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleRedThiefDagger;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.femaleGreenKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.femaleGreenMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.femaleGreenPeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.femaleGreenDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.femaleGreenThiefDagger;
                                    break;
                            }
                            break;
                    }
                    break;
                case "male":
                    switch (colorScreen.color)
                    {
                        case "purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.malePurpleKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.malePurpleMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.malePurplePeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.malePurpleDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.malePurpleThiefDagger;
                                    break;
                            }
                            break;
                        case "yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleYellowKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleYellowMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleYellowPeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleYellowDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleYellowThiefDagger;
                                    break;
                            }
                            break;
                        case "red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleRedKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleRedMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleRedPeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleRedDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleRedTheifDagger;
                                    break;
                            }
                            break;
                        case "green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    weaponBox.Image = Properties.Resources.maleGreenKnightDagger;
                                    break;
                                case "Mage":
                                    weaponBox.Image = Properties.Resources.maleGreenMageDagger;
                                    break;
                                case "Peasant":
                                    weaponBox.Image = Properties.Resources.maleGreenPeasantDagger;
                                    break;
                                case "Deprived":
                                    weaponBox.Image = Properties.Resources.maleGreenDeprivedDagger;
                                    break;
                                case "Rogue":
                                    weaponBox.Image = Properties.Resources.maleGreenThiefDagger;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void swordButton_MouseLeave(object sender, EventArgs e)
        {
            weaponBox.Image = null;
        }

        private void staffButton_MouseLeave(object sender, EventArgs e)
        {
            weaponBox.Image = null;
        }

        private void fistButton_MouseLeave(object sender, EventArgs e)
        {
            weaponBox.Image = null;
        }

        private void axeButtton_MouseLeave(object sender, EventArgs e)
        {
            weaponBox.Image = null;
        }

        private void daggerButton_MouseLeave(object sender, EventArgs e)
        {
            weaponBox.Image = null;
        }
        #endregion
        //when buttons are clicked the choice is saved the change screen method is run
        #region Button Click
        private void swordButton_Click_1(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femalePurpleKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femalePurpleMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femalePurplePeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femalePurpleDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic =Properties.Resources.femalePurpleThiefSword;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic =Properties.Resources.femaleYellowKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleYellowMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleYellowPeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleYellowDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleYellowThiefSword;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleRedKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleRedMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleRedPeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleRedDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleRedThiefSword;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleGreenKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleGreenMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleGreenPeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleGreenDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleGreenThiefSword;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.malePurpleKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.malePurpleMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.malePurplePeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.malePurpleDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.malePurpleThiefSword;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleYellowKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleYellowMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleYellowPeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleYellowDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleYellowThiefSword;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleRedKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleRedMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleRedPeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleRedDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleRedTheifSword;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleGreenKnightSword;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleGreenMageSword;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleGreenPeasantSword;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleGreenDeprivedSword;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleGreenThiefSword;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            weapon = "Sword";
            changeScreen();
        }

        private void staffButton_Click_1(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femalePurpleKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femalePurpleMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femalePurplePeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femalePurpleDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femalePurpleThiefStaff;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleYellowKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleYellowMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleYellowPeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleYellowDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleYellowThiefStaff;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleRedKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleRedMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleRedPeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleRedDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleRedThiefStaff;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleGreenKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleGreenMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleGreenPeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleGreenDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleGreenThiefStaff;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.malePurpleKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.malePurpleMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.malePurplePeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.malePurpleDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.malePurpleThiefStaff;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleYellowKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleYellowMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleYellowPeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleYellowDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleYellowThiefStaff;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleRedKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleRedMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleRedPeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleRedDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleRedTheifStaff;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleGreenKnightStaff;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleGreenMageStaff;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleGreenPeasantStaff;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleGreenDeprivedStaff;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleGreenThiefStaff;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            weapon = "Staff";
            changeScreen();
        }

        private void fistButton_Click_1(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femalePurpleKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femalePurpleMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femalePurplePeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femalePurpleDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femalePurpleThiefFist;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleYellowKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleYellowMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleYellowPeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleYellowDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleYellowThiefFist;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleRedKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleRedMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleRedPeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleRedDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleRedThiefFist;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleGreenKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleGreenMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleGreenPeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleGreenDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleGreenThiefFist;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.malePurpleKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.malePurpleMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.malePurplePeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.malePurpleDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.malePurpleThiefFist;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleYellowKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleYellowMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleYellowPeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleYellowDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleYellowThiefFist;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleRedKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleRedMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleRedPeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleRedDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleRedTheifFist;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleGreenKnightFist;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleGreenMageFist;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleGreenPeasantFist;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleGreenDeprivedFist;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleGreenThiefFist;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            weapon = "Fist";
            changeScreen();
        }

        private void axeButtton_Click(object sender, EventArgs e)
        {
            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femalePurpleKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femalePurpleMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femalePurplePeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femalePurpleDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femalePurpleThiefAxe;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleYellowKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleYellowMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleYellowPeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleYellowDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleYellowThiefAxe;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleRedKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleRedMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleRedPeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleRedDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleRedThiefAxe;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleGreenKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleGreenMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleGreenPeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleGreenDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleGreenThiefAxe;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.malePurpleKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.malePurpleMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.malePurplePeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.malePurpleDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.malePurpleThiefAxe;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleYellowKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleYellowMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleYellowPeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleYellowDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleYellowThiefAxe;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleRedKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleRedMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleRedPeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleRedDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleRedTheifAxe;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleGreenKnightAxe;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleGreenMageAxe;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleGreenPeasantAxe;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleGreenDeprivedAxe;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleGreenThiefAxe;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            weapon = "Axe";
            changeScreen();
        }

        private void daggerButton_Click_1(object sender, EventArgs e)
        {

            switch (GenderScreen.gender)
            {
                case "Female":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femalePurpleKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femalePurpleMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femalePurplePeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femalePurpleDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femalePurpleThiefDagger;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleYellowKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleYellowMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleYellowPeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleYellowDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleYellowThiefDagger;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleRedKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleRedMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleRedPeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleRedDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleRedThiefDagger;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.femaleGreenKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.femaleGreenMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.femaleGreenPeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.femaleGreenDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.femaleGreenThiefDagger;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Male":
                    switch (colorScreen.color)
                    {
                        case "Purple":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.malePurpleKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.malePurpleMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.malePurplePeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.malePurpleDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.malePurpleThiefDagger;
                                    break;
                            }
                            break;
                        case "Yellow":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleYellowKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleYellowMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleYellowPeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleYellowDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleYellowThiefDagger;
                                    break;
                            }
                            break;
                        case "Red":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleRedKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleRedMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleRedPeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleRedDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleRedTheifDagger;
                                    break;
                            }
                            break;
                        case "Green":
                            switch (clothingScreen.clothing)
                            {
                                case "Knight":
                                    finalPic = Properties.Resources.maleGreenKnightDagger;
                                    break;
                                case "Mage":
                                    finalPic = Properties.Resources.maleGreenMageDagger;
                                    break;
                                case "Peasant":
                                    finalPic = Properties.Resources.maleGreenPeasantDagger;
                                    break;
                                case "Deprived":
                                    finalPic = Properties.Resources.maleGreenDeprivedDagger;
                                    break;
                                case "Rogue":
                                    finalPic = Properties.Resources.maleGreenThiefDagger;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            weapon = "Dagger";
            changeScreen();
        }
        #endregion
    }
}
