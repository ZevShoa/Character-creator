namespace Character_creator
{
    partial class OldOrNewCharacter
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
            this.newCharacterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.char3Button = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.char1Button = new System.Windows.Forms.Button();
            this.char2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCharacterButton
            // 
            this.newCharacterButton.BackColor = System.Drawing.SystemColors.Control;
            this.newCharacterButton.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCharacterButton.ForeColor = System.Drawing.Color.Black;
            this.newCharacterButton.Location = new System.Drawing.Point(632, 270);
            this.newCharacterButton.Name = "newCharacterButton";
            this.newCharacterButton.Size = new System.Drawing.Size(406, 222);
            this.newCharacterButton.TabIndex = 28;
            this.newCharacterButton.Text = "Make New Character";
            this.newCharacterButton.UseVisualStyleBackColor = false;
            this.newCharacterButton.Click += new System.EventHandler(this.newCharacterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(980, 17);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 63);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(228, 82);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(650, 97);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Chose Your Character";
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectLabel.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(52, 202);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(367, 62);
            this.selectLabel.TabIndex = 32;
            this.selectLabel.Text = "Existing Character:";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.Transparent;
            this.orLabel.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.White;
            this.orLabel.Location = new System.Drawing.Point(517, 359);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(71, 62);
            this.orLabel.TabIndex = 33;
            this.orLabel.Text = "Or";
            // 
            // char3Button
            // 
            this.char3Button.BackColor = System.Drawing.SystemColors.Control;
            this.char3Button.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char3Button.ForeColor = System.Drawing.Color.Black;
            this.char3Button.Location = new System.Drawing.Point(33, 432);
            this.char3Button.Name = "char3Button";
            this.char3Button.Size = new System.Drawing.Size(406, 71);
            this.char3Button.TabIndex = 34;
            this.char3Button.UseVisualStyleBackColor = false;
            this.char3Button.Click += new System.EventHandler(this.selectOldCharacterButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Agency FB", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(12, 550);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(1014, 65);
            this.errorLabel.TabIndex = 35;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // char1Button
            // 
            this.char1Button.BackColor = System.Drawing.SystemColors.Control;
            this.char1Button.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char1Button.ForeColor = System.Drawing.Color.Black;
            this.char1Button.Location = new System.Drawing.Point(33, 278);
            this.char1Button.Name = "char1Button";
            this.char1Button.Size = new System.Drawing.Size(406, 71);
            this.char1Button.TabIndex = 36;
            this.char1Button.UseVisualStyleBackColor = false;
            this.char1Button.Click += new System.EventHandler(this.char1Button_Click);
            // 
            // char2Button
            // 
            this.char2Button.BackColor = System.Drawing.SystemColors.Control;
            this.char2Button.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char2Button.ForeColor = System.Drawing.Color.Black;
            this.char2Button.Location = new System.Drawing.Point(33, 355);
            this.char2Button.Name = "char2Button";
            this.char2Button.Size = new System.Drawing.Size(406, 71);
            this.char2Button.TabIndex = 37;
            this.char2Button.UseVisualStyleBackColor = false;
            this.char2Button.Click += new System.EventHandler(this.char2Button_Click);
            // 
            // OldOrNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.char2Button);
            this.Controls.Add(this.char1Button);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.char3Button);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.newCharacterButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "OldOrNewCharacter";
            this.Size = new System.Drawing.Size(1050, 700);
            this.Load += new System.EventHandler(this.OldOrNewCharacter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCharacterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button char3Button;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button char1Button;
        private System.Windows.Forms.Button char2Button;
    }
}
