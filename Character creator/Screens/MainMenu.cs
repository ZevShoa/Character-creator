using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Character_creator
{
    public partial class MainMenu : UserControl
    { 
        // Integers, strings, lists, and bools that are called later throughout the program
        public static List<User> userList = new List<User>();
        public static bool failure = false;
        public static bool space1 = true;
        public static bool space2 = true;
        public static bool space3 = true;
        string name, password, score, char1, char2, char3;
        string charName, clothes, colour, weapon,  gender;
        Image finalPic;
        public static List<Character> characterList = new List<Character>();
        public static string playerName;
        int index = 1;

        public MainMenu()
        {
            InitializeComponent();

            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Go to leaderboard
            Form f = this.FindForm();
            f.Controls.Remove(this);
            LoginScreen ls = new LoginScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            // Go to signup 
            Form f = this.FindForm();
            f.Controls.Remove(this);
            signUpScreen sus = new signUpScreen();
            sus.Location = new Point((f.Width - sus.Width) / 2, (f.Height - sus.Height) / 2);
            f.Controls.Add(sus);
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            // Go to leaderboard
            Form f = this.FindForm();
            f.Controls.Remove(this);
           LeaderboardScreen ls = new LeaderboardScreen();
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            // Go to options
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();
            os.Location = new Point((f.Width - os.Width) / 2, (f.Height - os.Height) / 2);
            f.Controls.Add(os);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Im not sure what this one does
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            // Open the file to be read
            XmlTextReader reader = new XmlTextReader("UserFile.xml");

            // Continue to read each element and text until the file is done
            while (reader.Read())
            {
                // the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        if (index == 1)
                        {
                            name = reader.Value;
                            index++;
                        }
                        else if (index == 2)
                        {
                            password = reader.Value;
                            index++;
                        }
                        else if (index == 3)
                        {
                            score = reader.Value;
                            index++;

                        }
                        else if (index == 4)
                        {
                            char1 = reader.Value;
                            index++;
                        }
                        else if (index == 5)
                        {
                            char2 = reader.Value;
                            index++;
                        }
                        else if (index == 6)
                        {
                            char3 = reader.Value;
                            index = 1;
                            User newUser = new User(name, password, score, char1, char2, char3);
                            userList.Add(newUser);
                        }
                    }
                }
            }
            // When done reading the file close it
            reader.Close();

            // Open the file to be read
            XmlTextReader Reader = new XmlTextReader("Characters.xml");

            // Continue to read each element and text until the file is done
            while (Reader.Read())
            {
                // the loop repeats getting the next piece of information
                if (Reader.NodeType == XmlNodeType.Text)
                {
                    if (index == 1)
                    {
                        charName = Reader.Value;
                        index++;
                    }
                    else if (index == 2)
                    {
                        clothes = Reader.Value;
                        index++;
                    }
                    else if (index == 3)
                    {
                        colour = Reader.Value;
                        index++;
                    }
                    else if (index == 4)
                    {
                        weapon = Reader.Value;
                        index++;

                    }
                    else if (index == 5)
                    {
                        gender = Reader.Value;
                        index++;
                    }
                    else if (index == 6)
                    {
                        switch (weapon)
                        {
                            case "Sword":
                                switch (gender)
                                {
                                    case "Female":
                                        switch (colour)
                                        {
                                            case "Purple":
                                                switch (clothes)
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
                                                        finalPic = Properties.Resources.femalePurpleThiefSword;
                                                        break;
                                                }
                                                break;
                                            case "Yellow":
                                                switch (clothes)
                                                {
                                                    case "Knight":
                                                        finalPic = Properties.Resources.femaleYellowKnightSword;
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                        switch (colour)
                                        {
                                            case "Purple":
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                break;
                            case "Staff":
                                switch (gender)
                                {
                                    case "Female":
                                        switch (colour)
                                        {
                                            case "Purple":
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                        switch (colour)
                                        {
                                            case "Purple":
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                break;
                            case "Fist":

                                switch(gender)
            {
                case "Female":
                                switch (colour)
                                {
                                    case "Purple":
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                                switch (colour)
                                {
                                    case "Purple":
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                        break;
                        case "Axe":
                         switch (gender)
                        {
                            case "Female":
                                switch (colour)
                                {
                                    case "Purple":
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                                switch (colour)
                                {
                                    case "Purple":
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                                        switch (clothes)
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
                        break;
                            case "Daggar":
                                switch (gender)
                                {
                                    case "Female":
                                        switch (colour)
                                        {
                                            case "Purple":
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                        switch (colour)
                                        {
                                            case "Purple":
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                                switch (clothes)
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
                                break;
                        }

                        index = 1;
                        Character newChar = new Character(charName, clothes, weapon, gender, colour, finalPic, 300, 250, 5);
                        characterList.Add(newChar);
                    }
                }
            }

            // When done reading the file close it
            Reader.Close();
            index = 1;

        }
    }
}
