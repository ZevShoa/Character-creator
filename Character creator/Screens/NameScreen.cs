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
        List<Image> finalCreations = new List<Image>(new Image[] {
        /*1*/Properties.Resources.femaleGreenDeprivedAxe, /*2*/Properties.Resources.femaleGreenDeprivedDagger, /*3*/Properties.Resources.femaleGreenDeprivedFist, /*4*/Properties.Resources.femaleGreenDeprivedStaff, /*5*/Properties.Resources.femaleGreenDeprivedSword, /*6*/Properties.Resources.femaleGreenKnightAxe, /*7*/Properties.Resources.femaleGreenKnightDagger, /*8*/Properties.Resources.femaleGreenKnightFist, /*9*/Properties.Resources.femaleGreenKnightStaff, /*10*/Properties.Resources.femaleGreenKnightSword, /*11*/Properties.Resources.femaleGreenMageAxe, /*12*/Properties.Resources.femaleGreenMageDagger, /*13*/Properties.Resources.femaleGreenMageFist, /*14*/Properties.Resources.femaleGreenMageStaff, /*15*/Properties.Resources.femaleGreenMageSword, /*16*/Properties.Resources.femaleGreenPeasantAxe, /*17*/Properties.Resources.femaleGreenPeasantDagger, /*18*/Properties.Resources.femaleGreenPeasantFist, /*19*/Properties.Resources.femaleGreenPeasantStaff, /*20*/Properties.Resources.femaleGreenPeasantSword, /*21*/Properties.Resources.femaleGreenThiefAxe, /*22*/Properties.Resources.femaleGreenThiefDagger, /*23*/Properties.Resources.femaleGreenThiefFist, /*24*/Properties.Resources.femaleGreenThiefStaff, /*25*/Properties.Resources.femaleGreenThiefSword,
        /*26*/Properties.Resources.femalePurpleDeprivedAxe,/*27*/Properties.Resources.femalePurpleDeprivedDagger,/*28*/Properties.Resources.femalePurpleDeprivedFist,/*29*/Properties.Resources.femalePurpleDeprivedStaff,/*30*/Properties.Resources.femalePurpleDeprivedSword,/*31*/Properties.Resources.femalePurpleKnightAxe,/*32*/Properties.Resources.femalePurpleKnightDagger,/*33*/Properties.Resources.femalePurpleKnightFist,/*34*/Properties.Resources.femalePurpleKnightStaff,/*35*/Properties.Resources.femalePurpleKnightSword,/*36*/Properties.Resources.femalePurpleMageAxe,/*37*/Properties.Resources.femalePurpleMageDagger,/*38*/Properties.Resources.femalePurpleMageFist,/*39*/Properties.Resources.femalePurpleMageStaff,/*40*/Properties.Resources.femalePurpleMageSword,/*41*/Properties.Resources.femalePurplePeasantAxe,/*42*/Properties.Resources.femalePurplePeasantDagger,/*43*/Properties.Resources.femalePurplePeasantFist,/*44*/Properties.Resources.femalePurplePeasantStaff,/*45*/Properties.Resources.femalePurplePeasantSword,/*46*/Properties.Resources.femalePurpleThiefAxe,/*47*/Properties.Resources.femalePurpleThiefDagger,/*48*/Properties.Resources.femalePurpleThiefFist,/*49*/Properties.Resources.femalePurpleThiefStaff,/*50*/Properties.Resources.femalePurpleThiefSword,
        /*51*/Properties.Resources.femaleRedDeprivedAxe,/*52*/Properties.Resources.femaleRedDeprivedDagger,/*53*/Properties.Resources.femaleRedDeprivedFist,/*54*/Properties.Resources.femaleRedDeprivedStaff,/*55*/Properties.Resources.femaleRedDeprivedSword,/*56*/Properties.Resources.femaleRedKnightAxe,/*57*/Properties.Resources.femaleRedKnightDagger,/*58*/Properties.Resources.femaleRedKnightFist,/*59*/Properties.Resources.femaleRedKnightStaff,/*60*/Properties.Resources.femaleRedKnightSword,/*61*/Properties.Resources.femaleRedMageAxe,/*62*/Properties.Resources.femaleRedMageDagger,/*63*/Properties.Resources.femaleRedMageFist,/*64*/Properties.Resources.femaleRedMageStaff,/*65*/Properties.Resources.femaleRedMageSword,/*66*/Properties.Resources.femaleRedPeasantAxe,/*67*/Properties.Resources.femaleRedPeasantDagger,/*68*/Properties.Resources.femaleRedPeasantFist,/*69*/Properties.Resources.femaleRedPeasantStaff,/*70*/Properties.Resources.femaleRedPeasantSword,/*71*/Properties.Resources.femaleRedThiefAxe,/*72*/Properties.Resources.femaleRedThiefDagger,/*73*/Properties.Resources.femaleRedThiefFist,/*74*/Properties.Resources.femaleRedThiefStaff,/*75*/Properties.Resources.femaleRedThiefSword,
        /*76*/Properties.Resources.femaleYellowDeprivedAxe,/*77*/Properties.Resources.femaleYellowDeprivedDagger,/*78*/Properties.Resources.femaleYellowDeprivedFist,/*79*/Properties.Resources.femaleYellowDeprivedStaff,/*80*/Properties.Resources.femaleYellowDeprivedSword,/*81*/Properties.Resources.femaleYellowKnightAxe,/*82*/Properties.Resources.femaleYellowKnightDagger,/*83*/Properties.Resources.femaleYellowKnightFist,/*84*/Properties.Resources.femaleYellowKnightStaff,/*85*/Properties.Resources.femaleYellowKnightSword,/*86*/Properties.Resources.femaleYellowMageAxe,/*87*/Properties.Resources.femaleYellowMageDagger,/*88*/Properties.Resources.femaleYellowMageFist,/*89*/Properties.Resources.femaleYellowMageStaff,/*90*/Properties.Resources.femaleYellowMageSword,/*91*/Properties.Resources.femaleYellowPeasantAxe,/*92*/Properties.Resources.femaleYellowPeasantDagger,/*93*/Properties.Resources.femaleYellowPeasantFist,/*94*/Properties.Resources.femaleYellowPeasantStaff,/*95*/Properties.Resources.femaleYellowPeasantSword,/*96*/Properties.Resources.femaleYellowThiefAxe,/*97*/Properties.Resources.femaleYellowThiefDagger,/*98*/Properties.Resources.femaleYellowThiefFist,/*99*/Properties.Resources.femaleYellowThiefStaff,/*100*/Properties.Resources.femaleYellowThiefSword,
        Properties.Resources.maleGreenDeprivedAxe, Properties.Resources.maleGreenDeprivedDagger, Properties.Resources.maleGreenDeprivedFist, Properties.Resources.maleGreenDeprivedStaff, Properties.Resources.maleGreenDeprivedSword, Properties.Resources.maleGreenKnightAxe, Properties.Resources.maleGreenKnightDagger, Properties.Resources.maleGreenKnightFist, Properties.Resources.maleGreenKnightStaff, Properties.Resources.maleGreenKnightSword, Properties.Resources.maleGreenMageAxe, Properties.Resources.maleGreenMageDagger, Properties.Resources.maleGreenMageFist, Properties.Resources.maleGreenMageStaff, Properties.Resources.maleGreenMageSword, Properties.Resources.maleGreenPeasantAxe, Properties.Resources.maleGreenPeasantDagger, Properties.Resources.maleGreenPeasantFist, Properties.Resources.maleGreenPeasantStaff, Properties.Resources.maleGreenPeasantSword, Properties.Resources.maleGreenThiefAxe, Properties.Resources.maleGreenThiefDagger, Properties.Resources.maleGreenThiefFist, Properties.Resources.maleGreenThiefStaff, Properties.Resources.maleGreenThiefSword,
        Properties.Resources.malePurpleDeprivedAxe,Properties.Resources.malePurpleDeprivedDagger,Properties.Resources.malePurpleDeprivedFist,Properties.Resources.malePurpleDeprivedStaff,Properties.Resources.malePurpleDeprivedSword,Properties.Resources.malePurpleKnightAxe,Properties.Resources.malePurpleKnightDagger,Properties.Resources.malePurpleKnightFist,Properties.Resources.malePurpleKnightStaff,Properties.Resources.malePurpleKnightSword,Properties.Resources.malePurpleMageAxe,Properties.Resources.malePurpleMageDagger,Properties.Resources.malePurpleMageFist,Properties.Resources.malePurpleMageStaff,Properties.Resources.malePurpleMageSword,Properties.Resources.malePurplePeasantAxe,Properties.Resources.malePurplePeasantDagger,Properties.Resources.malePurplePeasantFist,Properties.Resources.malePurplePeasantStaff,Properties.Resources.malePurplePeasantSword,Properties.Resources.malePurpleThiefAxe,Properties.Resources.malePurpleThiefDagger,Properties.Resources.malePurpleThiefFist,Properties.Resources.malePurpleThiefStaff,Properties.Resources.malePurpleThiefSword,
        Properties.Resources.maleRedDeprivedAxe,Properties.Resources.maleRedDeprivedDagger,Properties.Resources.maleRedDeprivedFist,Properties.Resources.maleRedDeprivedStaff,Properties.Resources.maleRedDeprivedSword,Properties.Resources.maleRedKnightAxe,Properties.Resources.maleRedKnightDagger,Properties.Resources.maleRedKnightFist,Properties.Resources.maleRedKnightStaff,Properties.Resources.maleRedKnightSword,Properties.Resources.maleRedMageAxe,Properties.Resources.maleRedMageDagger,Properties.Resources.maleRedMageFist,Properties.Resources.maleRedMageStaff,Properties.Resources.maleRedMageSword,Properties.Resources.maleRedPeasantAxe,Properties.Resources.maleRedPeasantDagger,Properties.Resources.maleRedPeasantFist,Properties.Resources.maleRedPeasantStaff,Properties.Resources.maleRedPeasantSword,Properties.Resources.maleRedTheifAxe,Properties.Resources.maleRedTheifDagger,Properties.Resources.maleRedTheifFist,Properties.Resources.maleRedTheifStaff,Properties.Resources.maleRedTheifSword,
        Properties.Resources.maleYellowDeprivedAxe,Properties.Resources.maleYellowDeprivedDagger,Properties.Resources.maleYellowDeprivedFist,Properties.Resources.maleYellowDeprivedStaff,Properties.Resources.maleYellowDeprivedSword,Properties.Resources.maleYellowKnightAxe,Properties.Resources.maleYellowKnightDagger,Properties.Resources.maleYellowKnightFist,Properties.Resources.maleYellowKnightStaff,Properties.Resources.maleYellowKnightSword,Properties.Resources.maleYellowMageAxe,Properties.Resources.maleYellowMageDagger,Properties.Resources.maleYellowMageFist,Properties.Resources.maleYellowMageStaff,Properties.Resources.maleYellowMageSword,Properties.Resources.maleYellowPeasantAxe,Properties.Resources.maleYellowPeasantDagger,Properties.Resources.maleYellowPeasantFist,Properties.Resources.maleYellowPeasantStaff,Properties.Resources.maleYellowPeasantSword,Properties.Resources.maleYellowThiefAxe,Properties.Resources.maleYellowThiefDagger,Properties.Resources.maleYellowThiefFist,Properties.Resources.maleYellowThiefStaff,Properties.Resources.maleYellowThiefSword
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