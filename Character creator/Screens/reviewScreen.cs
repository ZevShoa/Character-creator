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
    public partial class reviewScreen : UserControl
    {

        public reviewScreen()
        {
            InitializeComponent();
        }
        Character ch = new Character(NameScreen.name, clothingScreen.clothing, weaponScreen.weapon, GenderScreen.gender, colorScreen.color, statScreen.healthStat, statScreen.energyStat, weaponScreen.finalPic);
        private void reviewScreen_Load(object sender, EventArgs e)
        {
            nameLabel.Text = ch.name;
            classLabel.Text = "Class: " + ch.clothes;
            colorLabel.Text = "Color: " + ch.color;
            weaponLabel.Text = "Weapon: " + ch.weapon;
            healthLabel.Text = "Health: " + Convert.ToString(ch.healthStat);
            enrgyLabel.Text = "Energy: " + Convert.ToString(ch.energyStat);
            genderLabel.Text = ch.gender;
            finalPictureBox.Image = ch.picture;

         
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            statScreen ss = new statScreen();
            f.Controls.Add(ss);
            ss.Location = new Point((f.Width - ss.Width) / 2, (f.Height - ss.Height) / 2);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter(ch.name+".xml", null);

            writer.WriteStartElement("Character");
            writer.WriteStartElement(ch.name);
            writer.WriteElementString("name", ch.name);
            writer.WriteElementString("class", ch.clothes);
            writer.WriteElementString("color", ch.color);
            writer.WriteElementString("weapon", ch.weapon);
            writer.WriteElementString("gender", ch.gender);
            writer.WriteElementString("health Stat", Convert.ToString(ch.healthStat));
            writer.WriteElementString("energy Stat", Convert.ToString(ch.energyStat));
            writer.WriteElementString("Image", "finalPic");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();


        }
    }
}
