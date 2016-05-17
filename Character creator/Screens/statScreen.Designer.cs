namespace Character_creator
{
    partial class statScreen
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.healthPlusButton = new System.Windows.Forms.Button();
            this.energyMinusButton = new System.Windows.Forms.Button();
            this.healthMinusButton = new System.Windows.Forms.Button();
            this.energyPlusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(327, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 49);
            this.nameLabel.TabIndex = 0;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(311, 163);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(92, 49);
            this.healthLabel.TabIndex = 1;
            this.healthLabel.Text = "label1";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(307, 296);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(100, 49);
            this.energyLabel.TabIndex = 2;
            this.energyLabel.Text = "label2";
            // 
            // healthPlusButton
            // 
            this.healthPlusButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPlusButton.Location = new System.Drawing.Point(225, 164);
            this.healthPlusButton.Name = "healthPlusButton";
            this.healthPlusButton.Size = new System.Drawing.Size(50, 50);
            this.healthPlusButton.TabIndex = 3;
            this.healthPlusButton.Text = "+";
            this.healthPlusButton.UseVisualStyleBackColor = true;
            // 
            // energyMinusButton
            // 
            this.energyMinusButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyMinusButton.Location = new System.Drawing.Point(439, 297);
            this.energyMinusButton.Name = "energyMinusButton";
            this.energyMinusButton.Size = new System.Drawing.Size(50, 50);
            this.energyMinusButton.TabIndex = 4;
            this.energyMinusButton.Text = "-";
            this.energyMinusButton.UseVisualStyleBackColor = true;
            // 
            // healthMinusButton
            // 
            this.healthMinusButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthMinusButton.Location = new System.Drawing.Point(439, 164);
            this.healthMinusButton.Name = "healthMinusButton";
            this.healthMinusButton.Size = new System.Drawing.Size(50, 50);
            this.healthMinusButton.TabIndex = 5;
            this.healthMinusButton.Text = "-";
            this.healthMinusButton.UseVisualStyleBackColor = true;
            // 
            // energyPlusButton
            // 
            this.energyPlusButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyPlusButton.Location = new System.Drawing.Point(225, 297);
            this.energyPlusButton.Name = "energyPlusButton";
            this.energyPlusButton.Size = new System.Drawing.Size(50, 50);
            this.energyPlusButton.TabIndex = 6;
            this.energyPlusButton.Text = "+";
            this.energyPlusButton.UseVisualStyleBackColor = true;
            // 
            // statScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.energyPlusButton);
            this.Controls.Add(this.healthMinusButton);
            this.Controls.Add(this.energyMinusButton);
            this.Controls.Add(this.healthPlusButton);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "statScreen";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.statScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Button healthPlusButton;
        private System.Windows.Forms.Button energyMinusButton;
        private System.Windows.Forms.Button healthMinusButton;
        private System.Windows.Forms.Button energyPlusButton;
    }
}
