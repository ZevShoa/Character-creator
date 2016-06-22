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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.charHealthLabel = new System.Windows.Forms.Label();
            this.charEnergyLabel = new System.Windows.Forms.Label();
            this.charEnergyBar = new System.Windows.Forms.ProgressBar();
            this.charHealthBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // charHealthLabel
            // 
            this.charHealthLabel.AutoSize = true;
            this.charHealthLabel.BackColor = System.Drawing.Color.White;
            this.charHealthLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charHealthLabel.Location = new System.Drawing.Point(978, 589);
            this.charHealthLabel.Name = "charHealthLabel";
            this.charHealthLabel.Size = new System.Drawing.Size(62, 28);
            this.charHealthLabel.TabIndex = 0;
            this.charHealthLabel.Text = "Health:";
            // 
            // charEnergyLabel
            // 
            this.charEnergyLabel.AutoSize = true;
            this.charEnergyLabel.BackColor = System.Drawing.Color.White;
            this.charEnergyLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charEnergyLabel.Location = new System.Drawing.Point(978, 631);
            this.charEnergyLabel.Name = "charEnergyLabel";
            this.charEnergyLabel.Size = new System.Drawing.Size(67, 28);
            this.charEnergyLabel.TabIndex = 1;
            this.charEnergyLabel.Text = "Energy:";
            // 
            // charEnergyBar
            // 
            this.charEnergyBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.charEnergyBar.Location = new System.Drawing.Point(1093, 631);
            this.charEnergyBar.Name = "charEnergyBar";
            this.charEnergyBar.Size = new System.Drawing.Size(137, 28);
            this.charEnergyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.charEnergyBar.TabIndex = 13;
            this.charEnergyBar.Value = 100;
            // 
            // charHealthBar
            // 
            this.charHealthBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.charHealthBar.Location = new System.Drawing.Point(1093, 589);
            this.charHealthBar.Name = "charHealthBar";
            this.charHealthBar.Size = new System.Drawing.Size(137, 28);
            this.charHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.charHealthBar.TabIndex = 14;
            this.charHealthBar.Value = 100;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.WaveLevel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.charHealthBar);
            this.Controls.Add(this.charEnergyBar);
            this.Controls.Add(this.charEnergyLabel);
            this.Controls.Add(this.charHealthLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1800, 900);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label charHealthLabel;
        private System.Windows.Forms.Label charEnergyLabel;
        private System.Windows.Forms.ProgressBar charEnergyBar;
        private System.Windows.Forms.ProgressBar charHealthBar;
    }
}
