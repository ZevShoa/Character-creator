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
    public partial class failScreen : UserControl
    {
        public failScreen()
        {
            InitializeComponent();
        }

        private void failScreen_Load(object sender, EventArgs e)
        {
            //shows players score
            scoreLabel.Text = "Score:" + Convert.ToString(GameScreen.totalScore);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveXML();
            //closes the program if player rage quits
            Application.Exit();
        }

        private static void saveXML()
        {
            XmlTextWriter writer = new XmlTextWriter("Characters.xml", null);
            writer.WriteStartElement("Characters");
            for (int i = 0; i < characterDB.Count(); i++)
            {
                //Start "Employee" element
                writer.WriteStartElement("Characters");


                writer.WriteElementString("charClass", characterDB[i].charClass);
                writer.WriteElementString("Name", characterDB[i].name);
                writer.WriteElementString("Dex", characterDB[i].dexterity);
                writer.WriteElementString("Strength", characterDB[i].strength);
                writer.WriteElementString("Health", characterDB[i].health);
                writer.WriteElementString("Perk", characterDB[i].perk);

                // end the "Employee" element
                writer.WriteEndElement();
            }
            //Write the XML to file and close the writer
            writer.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //goes back to main menu
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu mm = new MainMenu();
            f.Controls.Add(mm);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
        }
    }
}
