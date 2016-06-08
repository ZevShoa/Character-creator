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
        //create a random number generator for choosing letters
        Random ranNum = new Random();
        int nameLength;
        int nextLetter;
        int vowel;        
        // created a list with all the letters of the alphabet in it
        string[] letters = {"a","e","i","o","u","y","g","h","c","j",
            "k","l","m","n","d","p","q","r","s","t","b","v","w","x","f","z"};
        //a list for the name
        List<string> theName = new List<string>();
        public static string name;
        public NameScreen()
        {
            InitializeComponent();
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //the user cant type more than 8 letters
            nameTextBox.MaxLength = 8;
        }

        private void ranNameButton_Click(object sender, EventArgs e)
        {
            //if the user wants a random name then this will run the random name generator
            NameMaker();
        }
        public void NameMaker()
        {
            //clears the name list so no overlap
            theName.Clear();
            //clears the text box 
            nameTextBox.Clear();
            //chooses a a length for the name
            nameLength = ranNum.Next(3, 8);
            //the loop that makes the name
            for (int i = 0; i < nameLength; i++)
            {
                //makes sure that there are is a vowel somewhere
                vowel = ranNum.Next(0, 5);
                //chooses a vowel from the first 5 letters in the list
                if (theName.Count % 3 == 1)
                {
                    theName.Add(letters[vowel]);
                }
                else
                {
                    //gets the rest of the letters in the name 
                    nextLetter = ranNum.Next(0, 26);
                    theName.Add(letters[nextLetter]);
                }
            }
            for (int i = 0; i < theName.Count; i++)
            {
                //projects the name to the text box
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