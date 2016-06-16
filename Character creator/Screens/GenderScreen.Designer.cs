namespace Character_creator
{
    partial class GenderScreen
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
            this.maleButton = new System.Windows.Forms.Button();
            this.femaleButton = new System.Windows.Forms.Button();
            this.genderPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.genderPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Agency FB", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(315, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 50);
            this.nameLabel.TabIndex = 0;
            // 
            // maleButton
            // 
            this.maleButton.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleButton.Location = new System.Drawing.Point(30, 93);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(166, 146);
            this.maleButton.TabIndex = 1;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.Click += new System.EventHandler(this.maleButton_Click);
            this.maleButton.MouseEnter += new System.EventHandler(this.maleButton_MouseEnter);
            this.maleButton.MouseLeave += new System.EventHandler(this.maleButton_MouseLeave);
            // 
            // femaleButton
            // 
            this.femaleButton.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.Location = new System.Drawing.Point(554, 93);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(166, 146);
            this.femaleButton.TabIndex = 2;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.Click += new System.EventHandler(this.femaleButton_Click);
            this.femaleButton.MouseEnter += new System.EventHandler(this.femaleButton_MouseEnter);
            this.femaleButton.MouseLeave += new System.EventHandler(this.femaleButton_MouseLeave);
            // 
            // genderPicBox
            // 
            this.genderPicBox.BackColor = System.Drawing.Color.MintCream;
            this.genderPicBox.Location = new System.Drawing.Point(219, 93);
            this.genderPicBox.Name = "genderPicBox";
            this.genderPicBox.Size = new System.Drawing.Size(300, 400);
            this.genderPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genderPicBox.TabIndex = 3;
            this.genderPicBox.TabStop = false;
            // 
            // GenderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.genderPicBox);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "GenderScreen";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.GenderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button maleButton;
        private System.Windows.Forms.Button femaleButton;
        private System.Windows.Forms.PictureBox genderPicBox;
    }
}
