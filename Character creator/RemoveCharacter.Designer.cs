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
            this.selectLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.char2Button = new System.Windows.Forms.Button();
            this.char1Button = new System.Windows.Forms.Button();
            this.char3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectLabel.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(142, 55);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(556, 160);
            this.selectLabel.TabIndex = 36;
            this.selectLabel.Text = "You Already Have Three Characters. Remove An Existing Character To Create A New O" +
    "ne:";
            this.selectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.errorLabel.Location = new System.Drawing.Point(115, 479);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(623, 116);
            this.errorLabel.TabIndex = 39;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // char2Button
            // 
            this.char2Button.BackColor = System.Drawing.SystemColors.Control;
            this.char2Button.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char2Button.ForeColor = System.Drawing.Color.Black;
            this.char2Button.Location = new System.Drawing.Point(227, 306);
            this.char2Button.Name = "char2Button";
            this.char2Button.Size = new System.Drawing.Size(406, 71);
            this.char2Button.TabIndex = 42;
            this.char2Button.UseVisualStyleBackColor = false;
            this.char2Button.Click += new System.EventHandler(this.char2Button_Click);
            // 
            // char1Button
            // 
            this.char1Button.BackColor = System.Drawing.SystemColors.Control;
            this.char1Button.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char1Button.ForeColor = System.Drawing.Color.Black;
            this.char1Button.Location = new System.Drawing.Point(227, 229);
            this.char1Button.Name = "char1Button";
            this.char1Button.Size = new System.Drawing.Size(406, 71);
            this.char1Button.TabIndex = 41;
            this.char1Button.UseVisualStyleBackColor = false;
            this.char1Button.Click += new System.EventHandler(this.char1Button_Click);
            // 
            // char3Button
            // 
            this.char3Button.BackColor = System.Drawing.SystemColors.Control;
            this.char3Button.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char3Button.ForeColor = System.Drawing.Color.Black;
            this.char3Button.Location = new System.Drawing.Point(227, 383);
            this.char3Button.Name = "char3Button";
            this.char3Button.Size = new System.Drawing.Size(406, 71);
            this.char3Button.TabIndex = 40;
            this.char3Button.UseVisualStyleBackColor = false;
            this.char3Button.Click += new System.EventHandler(this.char3Button_Click);
            // 
            // RemoveCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.char2Button);
            this.Controls.Add(this.char1Button);
            this.Controls.Add(this.char3Button);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.selectLabel);
            this.Name = "RemoveCharacter";
            this.Size = new System.Drawing.Size(821, 623);
            this.Load += new System.EventHandler(this.RemoveCharacter_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button char2Button;
        private System.Windows.Forms.Button char1Button;
        private System.Windows.Forms.Button char3Button;
    }
}
