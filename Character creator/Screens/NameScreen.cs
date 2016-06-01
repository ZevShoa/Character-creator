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
    public partial class NameScreen : UserControl
    {
        
        Random ranNum = new Random();
        int nameLength;
        int nextLetter;
        int vowel;
        List<Image> finalCreations = new List<Image>(new Image[] { Properties.Resources.femaleGreenDeprivedAxe, Properties.Resources.femaleGreenDeprivedDagger, Properties.Resources.femaleGreenDeprivedFist, Properties.Resources.femaleGreenDeprivedStaff, Properties.Resources.femaleGreenDeprivedSword, Properties.Resources.femaleGreenKnightAxe, Properties.Resources.femaleGreenKnightDagger, Properties.Resources.femaleGreenKnightFist, Properties.Resources.femaleGreenKnightStaff, Properties.Resources.femaleGreenKnightSword, Properties.Resources.femaleGreenMageAxe, Properties.Resources.femaleGreenMageDagger, Properties.Resources.femaleGreenMageFist, Properties.Resources.femaleGreenMageStaff, Properties.Resources.femaleGreenMageSword, Properties.Resources.femaleGreenPeasantAxe, Properties.Resources.femaleGreenPeasantDagger, Properties.Resources.femaleGreenPeasantFist, Properties.Resources.femaleGreenPeasantStaff, Properties.Resources.femaleGreenPeasantSword, Properties.Resources.femaleGreenThiefAxe, Properties.Resources.femaleGreenThiefDagger, Properties.Resources.femaleGreenThiefFist, Properties.Resources.femaleGreenThiefStaff, Properties.Resources.femaleGreenThiefSword,
        Properties.Resources.femalePurpleDeprivedAxe,Properties.Resources.femalePurpleDeprivedDagger,Properties.Resources.femalePurpleDeprivedFist,Properties.Resources.femalePurpleDeprivedStaff,Properties.Resources.femalePurpleDeprivedSword,Properties.Resources.femalePurpleKnightAxe,Properties.Resources.femalePurpleKnightDagger,Properties.Resources.femalePurpleKnightFist,Properties.Resources.femalePurpleKnightStaff,Properties.Resources.femalePurpleKnightSword,Properties.Resources.femalePurpleMageAxe,Properties.Resources.femalePurpleMageDagger,Properties.Resources.femalePurpleMageFist,Properties.Resources.femalePurpleMageStaff,Properties.Resources.femalePurpleMageSword,Properties.Resources.femalePurplePeasantAxe,Properties.Resources.femalePurplePeasantDagger,Properties.Resources.femalePurplePeasantFist,Properties.Resources.femalePurplePeasantStaff,Properties.Resources.femalePurplePeasantSword,Properties.Resources.femalePurpleThiefAxe,Properties.Resources.femalePurpleThiefDagger,Properties.Resources.femalePurpleThiefFist,Properties.Resources.femalePurpleThiefStaff,Properties.Resources.femalePurpleThiefSword,
        });

        string[] letters = {"a","e","i","o","u","y","g","h","c","j",
            "k","l","m","n","d","p","q","r","s","t","b","v","w","x","f","z"};
        List<string> theName = new List<string>();
        public static string name;
        public NameScreen()
        {
            InitializeComponent();
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.MaxLength = 8;
        }

        private void ranNameButton_Click(object sender, EventArgs e)
        {
            NameMaker();
        }
        public void NameMaker()
        {
            theName.Clear();
            nameTextBox.Clear();
            nameLength = ranNum.Next(3, 8);
            for (int i = 0; i < nameLength; i++)
            {
                vowel = ranNum.Next(0, 5);
                if (theName.Count % 3 == 1)
                {
                    theName.Add(letters[vowel]);
                }
                else
                {
                    nextLetter = ranNum.Next(0, 26);
                    theName.Add(letters[nextLetter]);
                }
            }
            for (int i = 0; i < theName.Count; i++)
            {
                nameTextBox.Text += theName[i];
            }
        }
        private void continueButton_Click_1(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0)
            {

            }
            else
            {
                name = nameTextBox.Text;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GenderScreen gs = new GenderScreen();
                f.Controls.Add(gs);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}