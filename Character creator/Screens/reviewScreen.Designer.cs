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
            this.healthLabel = new System.Windows.Forms.Label();
            this.enrgyLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.finalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.finalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(212, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(214, 116);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "name";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(267, 137);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(93, 49);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "class";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponLabel.Location = new System.Drawing.Point(23, 197);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(121, 49);
            this.weaponLabel.TabIndex = 2;
            this.weaponLabel.Text = "weapon";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(23, 291);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(108, 49);
            this.healthLabel.TabIndex = 3;
            this.healthLabel.Text = "Health:";
            // 
            // enrgyLabel
            // 
            this.enrgyLabel.AutoSize = true;
            this.enrgyLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrgyLabel.Location = new System.Drawing.Point(27, 359);
            this.enrgyLabel.Name = "enrgyLabel";
            this.enrgyLabel.Size = new System.Drawing.Size(117, 49);
            this.enrgyLabel.TabIndex = 4;
            this.enrgyLabel.Text = "Energy:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(267, 227);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(98, 49);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            // 
            // finalPictureBox
            // 
            this.finalPictureBox.Location = new System.Drawing.Point(611, 225);
            this.finalPictureBox.Name = "finalPictureBox";
            this.finalPictureBox.Size = new System.Drawing.Size(100, 50);
            this.finalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalPictureBox.TabIndex = 6;
            this.finalPictureBox.TabStop = false;
            // 
            // reviewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finalPictureBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.enrgyLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "reviewScreen";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.reviewScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label enrgyLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.PictureBox finalPictureBox;
    }
}
