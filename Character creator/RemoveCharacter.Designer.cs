namespace Character_creator
{
    partial class RemoveCharacter
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
            this.selectOldCharacterButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.characterBox = new System.Windows.Forms.ComboBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectOldCharacterButton
            // 
            this.selectOldCharacterButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectOldCharacterButton.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOldCharacterButton.ForeColor = System.Drawing.Color.Black;
            this.selectOldCharacterButton.Location = new System.Drawing.Point(29, 342);
            this.selectOldCharacterButton.Name = "selectOldCharacterButton";
            this.selectOldCharacterButton.Size = new System.Drawing.Size(642, 71);
            this.selectOldCharacterButton.TabIndex = 37;
            this.selectOldCharacterButton.Text = "Select";
            this.selectOldCharacterButton.UseVisualStyleBackColor = false;
            this.selectOldCharacterButton.Click += new System.EventHandler(this.selectOldCharacterButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectLabel.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(72, 81);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(556, 160);
            this.selectLabel.TabIndex = 36;
            this.selectLabel.Text = "You Already Have Three Characters. Remove An Existing Character To Create A New O" +
    "ne:";
            this.selectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterBox
            // 
            this.characterBox.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBox.FormattingEnabled = true;
            this.characterBox.Location = new System.Drawing.Point(138, 253);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(406, 70);
            this.characterBox.TabIndex = 35;
            this.characterBox.SelectedIndexChanged += new System.EventHandler(this.characterBox_SelectedIndexChanged);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Control;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 69);
            this.menuButton.TabIndex = 38;
            this.menuButton.Text = "↩";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Agency FB", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(33, 416);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(623, 116);
            this.errorLabel.TabIndex = 39;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.selectOldCharacterButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.characterBox);
            this.Name = "RemoveCharacter";
            this.Size = new System.Drawing.Size(695, 546);
            this.Load += new System.EventHandler(this.RemoveCharacter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectOldCharacterButton;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.ComboBox characterBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
