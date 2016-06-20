namespace Character_creator
{
    partial class BattleScreen
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
            this.components = new System.ComponentModel.Container();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.attackOneButton = new System.Windows.Forms.Button();
            this.attackTwoButton = new System.Windows.Forms.Button();
            this.attackThreeButton = new System.Windows.Forms.Button();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerEnergyLabel = new System.Windows.Forms.Label();
            this.playerEnergyBar = new System.Windows.Forms.ProgressBar();
            this.energyNameLabel = new System.Windows.Forms.Label();
            this.playerHealthNumberLabel = new System.Windows.Forms.Label();
            this.monsterHealthNunberLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.announcerLabel = new System.Windows.Forms.Label();
            this.monsterBox = new System.Windows.Forms.PictureBox();
            this.characterBox = new System.Windows.Forms.PictureBox();
            this.battleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monsterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monsterHealthLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHealthLabel.ForeColor = System.Drawing.Color.MintCream;
            this.monsterHealthLabel.Location = new System.Drawing.Point(282, 270);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(57, 31);
            this.monsterHealthLabel.TabIndex = 3;
            this.monsterHealthLabel.Text = "100%";
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerHealthBar.Location = new System.Drawing.Point(620, 88);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(185, 23);
            this.playerHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHealthBar.TabIndex = 5;
            this.playerHealthBar.Value = 100;
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monsterHealthBar.Location = new System.Drawing.Point(91, 278);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(185, 23);
            this.monsterHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monsterHealthBar.TabIndex = 6;
            this.monsterHealthBar.Value = 100;
            // 
            // attackOneButton
            // 
            this.attackOneButton.BackColor = System.Drawing.Color.White;
            this.attackOneButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackOneButton.Location = new System.Drawing.Point(73, 667);
            this.attackOneButton.Name = "attackOneButton";
            this.attackOneButton.Size = new System.Drawing.Size(252, 60);
            this.attackOneButton.TabIndex = 7;
            this.attackOneButton.Text = "Attack One";
            this.attackOneButton.UseVisualStyleBackColor = false;
            this.attackOneButton.Click += new System.EventHandler(this.attackOneButton_Click);
            // 
            // attackTwoButton
            // 
            this.attackTwoButton.BackColor = System.Drawing.Color.White;
            this.attackTwoButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackTwoButton.Location = new System.Drawing.Point(405, 667);
            this.attackTwoButton.Name = "attackTwoButton";
            this.attackTwoButton.Size = new System.Drawing.Size(252, 60);
            this.attackTwoButton.TabIndex = 8;
            this.attackTwoButton.Text = "Attack Two";
            this.attackTwoButton.UseVisualStyleBackColor = false;
            this.attackTwoButton.Click += new System.EventHandler(this.attackTwoButton_Click);
            // 
            // attackThreeButton
            // 
            this.attackThreeButton.BackColor = System.Drawing.Color.White;
            this.attackThreeButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackThreeButton.Location = new System.Drawing.Point(737, 667);
            this.attackThreeButton.Name = "attackThreeButton";
            this.attackThreeButton.Size = new System.Drawing.Size(252, 60);
            this.attackThreeButton.TabIndex = 9;
            this.attackThreeButton.Text = "Attack Three";
            this.attackThreeButton.UseVisualStyleBackColor = false;
            this.attackThreeButton.Click += new System.EventHandler(this.attackThreeButton_Click);
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.ForeColor = System.Drawing.Color.White;
            this.playerHealthLabel.Location = new System.Drawing.Point(802, 82);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(57, 31);
            this.playerHealthLabel.TabIndex = 10;
            this.playerHealthLabel.Text = "100%";
            // 
            // playerEnergyLabel
            // 
            this.playerEnergyLabel.AutoSize = true;
            this.playerEnergyLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerEnergyLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEnergyLabel.ForeColor = System.Drawing.Color.White;
            this.playerEnergyLabel.Location = new System.Drawing.Point(802, 35);
            this.playerEnergyLabel.Name = "playerEnergyLabel";
            this.playerEnergyLabel.Size = new System.Drawing.Size(57, 31);
            this.playerEnergyLabel.TabIndex = 11;
            this.playerEnergyLabel.Text = "100%";
            // 
            // playerEnergyBar
            // 
            this.playerEnergyBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerEnergyBar.Location = new System.Drawing.Point(620, 43);
            this.playerEnergyBar.Name = "playerEnergyBar";
            this.playerEnergyBar.Size = new System.Drawing.Size(185, 23);
            this.playerEnergyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerEnergyBar.TabIndex = 12;
            this.playerEnergyBar.Value = 100;
            // 
            // energyNameLabel
            // 
            this.energyNameLabel.AutoSize = true;
            this.energyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.energyNameLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyNameLabel.ForeColor = System.Drawing.Color.White;
            this.energyNameLabel.Location = new System.Drawing.Point(542, 32);
            this.energyNameLabel.Name = "energyNameLabel";
            this.energyNameLabel.Size = new System.Drawing.Size(72, 31);
            this.energyNameLabel.TabIndex = 13;
            this.energyNameLabel.Text = "Energy:";
            // 
            // playerHealthNumberLabel
            // 
            this.playerHealthNumberLabel.AutoSize = true;
            this.playerHealthNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthNumberLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthNumberLabel.ForeColor = System.Drawing.Color.White;
            this.playerHealthNumberLabel.Location = new System.Drawing.Point(542, 82);
            this.playerHealthNumberLabel.Name = "playerHealthNumberLabel";
            this.playerHealthNumberLabel.Size = new System.Drawing.Size(66, 31);
            this.playerHealthNumberLabel.TabIndex = 14;
            this.playerHealthNumberLabel.Text = "Health:";
            // 
            // monsterHealthNunberLabel
            // 
            this.monsterHealthNunberLabel.AutoSize = true;
            this.monsterHealthNunberLabel.BackColor = System.Drawing.Color.Transparent;
            this.monsterHealthNunberLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHealthNunberLabel.ForeColor = System.Drawing.Color.White;
            this.monsterHealthNunberLabel.Location = new System.Drawing.Point(19, 270);
            this.monsterHealthNunberLabel.Name = "monsterHealthNunberLabel";
            this.monsterHealthNunberLabel.Size = new System.Drawing.Size(66, 31);
            this.monsterHealthNunberLabel.TabIndex = 15;
            this.monsterHealthNunberLabel.Text = "Health:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(989, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 63);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "| |";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // announcerLabel
            // 
            this.announcerLabel.AutoSize = true;
            this.announcerLabel.BackColor = System.Drawing.Color.Transparent;
            this.announcerLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcerLabel.ForeColor = System.Drawing.Color.White;
            this.announcerLabel.Location = new System.Drawing.Point(16, 22);
            this.announcerLabel.Name = "announcerLabel";
            this.announcerLabel.Size = new System.Drawing.Size(0, 44);
            this.announcerLabel.TabIndex = 17;
            // 
            // monsterBox
            // 
            this.monsterBox.BackColor = System.Drawing.Color.Transparent;
            this.monsterBox.Location = new System.Drawing.Point(24, 320);
            this.monsterBox.Name = "monsterBox";
            this.monsterBox.Size = new System.Drawing.Size(300, 300);
            this.monsterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.monsterBox.TabIndex = 2;
            this.monsterBox.TabStop = false;
            // 
            // characterBox
            // 
            this.characterBox.BackColor = System.Drawing.Color.Transparent;
            this.characterBox.Location = new System.Drawing.Point(554, 132);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(294, 378);
            this.characterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.characterBox.TabIndex = 1;
            this.characterBox.TabStop = false;
            // 
            // battleTimer
            // 
            this.battleTimer.Tick += new System.EventHandler(this.battleTimer_Tick);
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.jungleBattle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.announcerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monsterHealthNunberLabel);
            this.Controls.Add(this.playerHealthNumberLabel);
            this.Controls.Add(this.energyNameLabel);
            this.Controls.Add(this.playerEnergyBar);
            this.Controls.Add(this.playerEnergyLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.attackThreeButton);
            this.Controls.Add(this.attackTwoButton);
            this.Controls.Add(this.attackOneButton);
            this.Controls.Add(this.monsterHealthBar);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.monsterBox);
            this.Controls.Add(this.characterBox);
            this.Name = "BattleScreen";
            this.Size = new System.Drawing.Size(1050, 769);
            this.Load += new System.EventHandler(this.BattleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monsterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox characterBox;
        private System.Windows.Forms.PictureBox monsterBox;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.ProgressBar monsterHealthBar;
        private System.Windows.Forms.Button attackOneButton;
        private System.Windows.Forms.Button attackTwoButton;
        private System.Windows.Forms.Button attackThreeButton;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label playerEnergyLabel;
        private System.Windows.Forms.ProgressBar playerEnergyBar;
        private System.Windows.Forms.Label energyNameLabel;
        private System.Windows.Forms.Label playerHealthNumberLabel;
        private System.Windows.Forms.Label monsterHealthNunberLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label announcerLabel;
        private System.Windows.Forms.Timer battleTimer;
    }
}
