namespace Character_creator
{
    partial class NameScreen
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameChooseLabel = new System.Windows.Forms.Label();
            this.ranNameButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(258, 124);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(364, 57);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameChooseLabel
            // 
            this.nameChooseLabel.AutoSize = true;
            this.nameChooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameChooseLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChooseLabel.ForeColor = System.Drawing.Color.White;
            this.nameChooseLabel.Location = new System.Drawing.Point(184, 33);
            this.nameChooseLabel.Name = "nameChooseLabel";
            this.nameChooseLabel.Size = new System.Drawing.Size(509, 88);
            this.nameChooseLabel.TabIndex = 1;
            this.nameChooseLabel.Text = "Choose Your Name";
            // 
            // ranNameButton
            // 
            this.ranNameButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranNameButton.Location = new System.Drawing.Point(127, 293);
            this.ranNameButton.Name = "ranNameButton";
            this.ranNameButton.Size = new System.Drawing.Size(597, 68);
            this.ranNameButton.TabIndex = 2;
            this.ranNameButton.Text = "Random";
            this.ranNameButton.UseVisualStyleBackColor = true;
            this.ranNameButton.Click += new System.EventHandler(this.ranNameButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(127, 384);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(597, 67);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue ";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click_1);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Agency FB", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(37, 202);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(774, 65);
            this.errorLabel.TabIndex = 23;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.ranNameButton);
            this.Controls.Add(this.nameChooseLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "NameScreen";
            this.Size = new System.Drawing.Size(833, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameChooseLabel;
        private System.Windows.Forms.Button ranNameButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
