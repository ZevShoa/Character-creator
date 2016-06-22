namespace Character_creator
{
    partial class GiftScreen
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
            this.battleScoreLabel = new System.Windows.Forms.Label();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.giftLabel = new System.Windows.Forms.Label();
            this.energyGiftLabel = new System.Windows.Forms.Label();
            this.healthGiftLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battleScoreLabel
            // 
            this.battleScoreLabel.AutoSize = true;
            this.battleScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.battleScoreLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleScoreLabel.ForeColor = System.Drawing.Color.White;
            this.battleScoreLabel.Location = new System.Drawing.Point(103, 129);
            this.battleScoreLabel.Name = "battleScoreLabel";
            this.battleScoreLabel.Size = new System.Drawing.Size(255, 49);
            this.battleScoreLabel.TabIndex = 0;
            this.battleScoreLabel.Text = "Your Battle Score:";
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalScoreLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLabel.ForeColor = System.Drawing.Color.White;
            this.totalScoreLabel.Location = new System.Drawing.Point(103, 194);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(244, 49);
            this.totalScoreLabel.TabIndex = 1;
            this.totalScoreLabel.Text = "Your Total Score:";
            // 
            // giftLabel
            // 
            this.giftLabel.AutoSize = true;
            this.giftLabel.BackColor = System.Drawing.Color.Transparent;
            this.giftLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giftLabel.ForeColor = System.Drawing.Color.White;
            this.giftLabel.Location = new System.Drawing.Point(103, 258);
            this.giftLabel.Name = "giftLabel";
            this.giftLabel.Size = new System.Drawing.Size(130, 49);
            this.giftLabel.TabIndex = 2;
            this.giftLabel.Text = "You Win:";
            // 
            // energyGiftLabel
            // 
            this.energyGiftLabel.AutoSize = true;
            this.energyGiftLabel.BackColor = System.Drawing.Color.Transparent;
            this.energyGiftLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyGiftLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.energyGiftLabel.Location = new System.Drawing.Point(383, 272);
            this.energyGiftLabel.Name = "energyGiftLabel";
            this.energyGiftLabel.Size = new System.Drawing.Size(115, 50);
            this.energyGiftLabel.TabIndex = 3;
            this.energyGiftLabel.Text = "Energy";
            // 
            // healthGiftLabel
            // 
            this.healthGiftLabel.AutoSize = true;
            this.healthGiftLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthGiftLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthGiftLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.healthGiftLabel.Location = new System.Drawing.Point(383, 338);
            this.healthGiftLabel.Name = "healthGiftLabel";
            this.healthGiftLabel.Size = new System.Drawing.Size(108, 50);
            this.healthGiftLabel.TabIndex = 4;
            this.healthGiftLabel.Text = "Health";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Agency FB", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(194, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(468, 67);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "You Have Won This Time";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(21, 427);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(768, 86);
            this.continueButton.TabIndex = 6;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // GiftScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.healthGiftLabel);
            this.Controls.Add(this.energyGiftLabel);
            this.Controls.Add(this.giftLabel);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.battleScoreLabel);
            this.Name = "GiftScreen";
            this.Size = new System.Drawing.Size(804, 528);
            this.Load += new System.EventHandler(this.GiftScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label battleScoreLabel;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Label giftLabel;
        private System.Windows.Forms.Label energyGiftLabel;
        private System.Windows.Forms.Label healthGiftLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button continueButton;
    }
}
