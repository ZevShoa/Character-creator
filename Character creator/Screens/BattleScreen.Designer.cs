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
            this.characterBox = new System.Windows.Forms.PictureBox();
            this.monsterBox = new System.Windows.Forms.PictureBox();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.attackOneButton = new System.Windows.Forms.Button();
            this.attackTwoButton = new System.Windows.Forms.Button();
            this.attackThreeButton = new System.Windows.Forms.Button();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerEnergyLabel = new System.Windows.Forms.Label();
            this.playerEnergyBar = new System.Windows.Forms.ProgressBar();
            this.energyNumberLabel = new System.Windows.Forms.Label();
            this.playerHealthNumberLabel = new System.Windows.Forms.Label();
            this.monsterHealthNunberLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterBox
            // 
            this.characterBox.Location = new System.Drawing.Point(554, 132);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(294, 378);
            this.characterBox.TabIndex = 1;
            this.characterBox.TabStop = false;
            // 
            // monsterBox
            // 
            this.monsterBox.Location = new System.Drawing.Point(24, 320);
            this.monsterBox.Name = "monsterBox";
            this.monsterBox.Size = new System.Drawing.Size(294, 250);
            this.monsterBox.TabIndex = 2;
            this.monsterBox.TabStop = false;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHealthLabel.Location = new System.Drawing.Point(18, 270);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(66, 31);
            this.monsterHealthLabel.TabIndex = 3;
            this.monsterHealthLabel.Text = "Health:";
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerHealthBar.Location = new System.Drawing.Point(620, 88);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(185, 23);
            this.playerHealthBar.TabIndex = 5;
            this.playerHealthBar.Value = 100;
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monsterHealthBar.Location = new System.Drawing.Point(91, 278);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(185, 23);
            this.monsterHealthBar.TabIndex = 6;
            this.monsterHealthBar.Value = 100;
            // 
            // attackOneButton
            // 
            this.attackOneButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackOneButton.Location = new System.Drawing.Point(73, 667);
            this.attackOneButton.Name = "attackOneButton";
            this.attackOneButton.Size = new System.Drawing.Size(252, 60);
            this.attackOneButton.TabIndex = 7;
            this.attackOneButton.Text = "Attack One";
            this.attackOneButton.UseVisualStyleBackColor = true;
            this.attackOneButton.Click += new System.EventHandler(this.attackOneButton_Click);
            // 
            // attackTwoButton
            // 
            this.attackTwoButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackTwoButton.Location = new System.Drawing.Point(405, 667);
            this.attackTwoButton.Name = "attackTwoButton";
            this.attackTwoButton.Size = new System.Drawing.Size(252, 60);
            this.attackTwoButton.TabIndex = 8;
            this.attackTwoButton.Text = "Attack Two";
            this.attackTwoButton.UseVisualStyleBackColor = true;
            this.attackTwoButton.Click += new System.EventHandler(this.attackTwoButton_Click);
            // 
            // attackThreeButton
            // 
            this.attackThreeButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackThreeButton.Location = new System.Drawing.Point(737, 667);
            this.attackThreeButton.Name = "attackThreeButton";
            this.attackThreeButton.Size = new System.Drawing.Size(252, 60);
            this.attackThreeButton.TabIndex = 9;
            this.attackThreeButton.Text = "Attack Three";
            this.attackThreeButton.UseVisualStyleBackColor = true;
            this.attackThreeButton.Click += new System.EventHandler(this.attackThreeButton_Click);
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.Location = new System.Drawing.Point(548, 80);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(66, 31);
            this.playerHealthLabel.TabIndex = 10;
            this.playerHealthLabel.Text = "Health:";
            // 
            // playerEnergyLabel
            // 
            this.playerEnergyLabel.AutoSize = true;
            this.playerEnergyLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEnergyLabel.Location = new System.Drawing.Point(548, 35);
            this.playerEnergyLabel.Name = "playerEnergyLabel";
            this.playerEnergyLabel.Size = new System.Drawing.Size(72, 31);
            this.playerEnergyLabel.TabIndex = 11;
            this.playerEnergyLabel.Text = "Energy:";
            // 
            // playerEnergyBar
            // 
            this.playerEnergyBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerEnergyBar.Location = new System.Drawing.Point(620, 43);
            this.playerEnergyBar.Name = "playerEnergyBar";
            this.playerEnergyBar.Size = new System.Drawing.Size(185, 23);
            this.playerEnergyBar.TabIndex = 12;
            this.playerEnergyBar.Value = 100;
            // 
            // energyNumberLabel
            // 
            this.energyNumberLabel.AutoSize = true;
            this.energyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.energyNumberLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyNumberLabel.Location = new System.Drawing.Point(802, 43);
            this.energyNumberLabel.Name = "energyNumberLabel";
            this.energyNumberLabel.Size = new System.Drawing.Size(46, 24);
            this.energyNumberLabel.TabIndex = 13;
            this.energyNumberLabel.Text = "100%";
            // 
            // playerHealthNumberLabel
            // 
            this.playerHealthNumberLabel.AutoSize = true;
            this.playerHealthNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthNumberLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthNumberLabel.Location = new System.Drawing.Point(802, 88);
            this.playerHealthNumberLabel.Name = "playerHealthNumberLabel";
            this.playerHealthNumberLabel.Size = new System.Drawing.Size(46, 24);
            this.playerHealthNumberLabel.TabIndex = 14;
            this.playerHealthNumberLabel.Text = "100%";
            // 
            // monsterHealthNunberLabel
            // 
            this.monsterHealthNunberLabel.AutoSize = true;
            this.monsterHealthNunberLabel.BackColor = System.Drawing.Color.Transparent;
            this.monsterHealthNunberLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHealthNunberLabel.Location = new System.Drawing.Point(279, 278);
            this.monsterHealthNunberLabel.Name = "monsterHealthNunberLabel";
            this.monsterHealthNunberLabel.Size = new System.Drawing.Size(46, 24);
            this.monsterHealthNunberLabel.TabIndex = 15;
            this.monsterHealthNunberLabel.Text = "100%";
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
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monsterHealthNunberLabel);
            this.Controls.Add(this.playerHealthNumberLabel);
            this.Controls.Add(this.energyNumberLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBox)).EndInit();
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
        private System.Windows.Forms.Label energyNumberLabel;
        private System.Windows.Forms.Label playerHealthNumberLabel;
        private System.Windows.Forms.Label monsterHealthNunberLabel;
        private System.Windows.Forms.Button exitButton;
    }
}
