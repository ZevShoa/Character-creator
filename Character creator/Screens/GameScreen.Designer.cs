namespace Character_creator
{
    partial class GameScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterBox
            // 
            this.characterBox.Location = new System.Drawing.Point(44, 552);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(123, 192);
            this.characterBox.TabIndex = 2;
            this.characterBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(989, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 63);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "| |";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.characterBox);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1050, 769);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox characterBox;
        private System.Windows.Forms.Button exitButton;
    }
}
