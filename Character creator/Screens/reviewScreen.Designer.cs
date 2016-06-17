namespace Character_creator
{
    partial class reviewScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.finalPictureBox = new System.Windows.Forms.PictureBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.finalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(223, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(177, 88);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BackColor = System.Drawing.Color.Transparent;
            this.classLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.ForeColor = System.Drawing.Color.White;
            this.classLabel.Location = new System.Drawing.Point(39, 349);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(105, 50);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Class:";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.BackColor = System.Drawing.Color.Transparent;
            this.weaponLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponLabel.ForeColor = System.Drawing.Color.White;
            this.weaponLabel.Location = new System.Drawing.Point(39, 140);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(134, 50);
            this.weaponLabel.TabIndex = 2;
            this.weaponLabel.Text = "Weapon:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.ForeColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(41, 448);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(103, 50);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            // 
            // finalPictureBox
            // 
            this.finalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.finalPictureBox.Location = new System.Drawing.Point(368, 140);
            this.finalPictureBox.Name = "finalPictureBox";
            this.finalPictureBox.Size = new System.Drawing.Size(300, 400);
            this.finalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalPictureBox.TabIndex = 6;
            this.finalPictureBox.TabStop = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(39, 241);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(127, 50);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(368, 561);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(300, 69);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save and Play";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-22, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-22, -22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reviewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.finalPictureBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "reviewScreen";
            this.Size = new System.Drawing.Size(725, 633);
            this.Load += new System.EventHandler(this.reviewScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.PictureBox finalPictureBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
