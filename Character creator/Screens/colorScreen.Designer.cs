namespace Character_creator
{
    partial class colorScreen
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
            this.purpleButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.DarkViolet;
            this.purpleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleButton.Location = new System.Drawing.Point(62, 119);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(100, 100);
            this.purpleButton.TabIndex = 0;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.purpleButton_MouseClick);
            this.purpleButton.MouseEnter += new System.EventHandler(this.purpleButton_MouseEnter);
            this.purpleButton.MouseLeave += new System.EventHandler(this.purpleButton_MouseLeave);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Location = new System.Drawing.Point(585, 119);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(100, 100);
            this.yellowButton.TabIndex = 1;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            this.yellowButton.MouseEnter += new System.EventHandler(this.yellowButton_MouseEnter);
            this.yellowButton.MouseLeave += new System.EventHandler(this.yellowButton_MouseLeave);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(62, 364);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(100, 100);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            this.redButton.MouseEnter += new System.EventHandler(this.redButton_MouseEnter);
            this.redButton.MouseLeave += new System.EventHandler(this.redButton_MouseLeave);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(585, 364);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(100, 100);
            this.greenButton.TabIndex = 3;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            this.greenButton.MouseEnter += new System.EventHandler(this.greenButton_MouseEnter);
            this.greenButton.MouseLeave += new System.EventHandler(this.greenButton_MouseLeave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(337, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 53);
            this.nameLabel.TabIndex = 5;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Transparent;
            this.colorBox.Location = new System.Drawing.Point(234, 64);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(300, 400);
            this.colorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorBox.TabIndex = 4;
            this.colorBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(31, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 60);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "↩";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // colorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.purpleButton);
            this.Name = "colorScreen";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.colorScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backButton;
    }
}
