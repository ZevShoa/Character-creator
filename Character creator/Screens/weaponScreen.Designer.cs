namespace Character_creator
{
    partial class weaponScreen
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
            this.swordButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.axeButton = new System.Windows.Forms.Button();
            this.daggerButton = new System.Windows.Forms.Button();
            this.fistButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // swordButton
            // 
            this.swordButton.BackColor = System.Drawing.Color.Transparent;
            this.swordButton.BackgroundImage = global::Character_creator.Properties.Resources.sword;
            this.swordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordButton.Location = new System.Drawing.Point(25, 143);
            this.swordButton.Name = "swordButton";
            this.swordButton.Size = new System.Drawing.Size(175, 175);
            this.swordButton.TabIndex = 0;
            this.swordButton.UseVisualStyleBackColor = false;
            this.swordButton.Click += new System.EventHandler(this.swordButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.BackColor = System.Drawing.Color.Transparent;
            this.staffButton.BackgroundImage = global::Character_creator.Properties.Resources.staff;
            this.staffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staffButton.Location = new System.Drawing.Point(125, 302);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(175, 175);
            this.staffButton.TabIndex = 1;
            this.staffButton.UseVisualStyleBackColor = false;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // axeButton
            // 
            this.axeButton.BackColor = System.Drawing.Color.Transparent;
            this.axeButton.BackgroundImage = global::Character_creator.Properties.Resources.axe;
            this.axeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.axeButton.Location = new System.Drawing.Point(277, 143);
            this.axeButton.Name = "axeButton";
            this.axeButton.Size = new System.Drawing.Size(175, 175);
            this.axeButton.TabIndex = 2;
            this.axeButton.UseVisualStyleBackColor = false;
            this.axeButton.Click += new System.EventHandler(this.axeButton_Click);
            // 
            // daggerButton
            // 
            this.daggerButton.BackColor = System.Drawing.Color.Transparent;
            this.daggerButton.BackgroundImage = global::Character_creator.Properties.Resources.dagger;
            this.daggerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.daggerButton.Location = new System.Drawing.Point(427, 302);
            this.daggerButton.Name = "daggerButton";
            this.daggerButton.Size = new System.Drawing.Size(175, 175);
            this.daggerButton.TabIndex = 3;
            this.daggerButton.UseVisualStyleBackColor = false;
            this.daggerButton.Click += new System.EventHandler(this.daggerButton_Click);
            // 
            // fistButton
            // 
            this.fistButton.BackColor = System.Drawing.Color.Transparent;
            this.fistButton.BackgroundImage = global::Character_creator.Properties.Resources.fist;
            this.fistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fistButton.Location = new System.Drawing.Point(529, 143);
            this.fistButton.Name = "fistButton";
            this.fistButton.Size = new System.Drawing.Size(175, 175);
            this.fistButton.TabIndex = 4;
            this.fistButton.UseVisualStyleBackColor = false;
            this.fistButton.Click += new System.EventHandler(this.fistButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(331, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 49);
            this.nameLabel.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(25, 27);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 60);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "↩";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // weaponScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Character_creator.Properties.Resources.brick;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fistButton);
            this.Controls.Add(this.daggerButton);
            this.Controls.Add(this.axeButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.swordButton);
            this.Name = "weaponScreen";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.weaponScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button swordButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button axeButton;
        private System.Windows.Forms.Button daggerButton;
        private System.Windows.Forms.Button fistButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backButton;
    }
}
