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
            this.monsterImage = new System.Windows.Forms.PictureBox();
            this.characterImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monsterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // monsterImage
            // 
            this.monsterImage.BackColor = System.Drawing.Color.Transparent;
            this.monsterImage.Location = new System.Drawing.Point(15, 499);
            this.monsterImage.Name = "monsterImage";
            this.monsterImage.Size = new System.Drawing.Size(150, 150);
            this.monsterImage.TabIndex = 0;
            this.monsterImage.TabStop = false;
            // 
            // characterImage
            // 
            this.characterImage.BackColor = System.Drawing.Color.Transparent;
            this.characterImage.Location = new System.Drawing.Point(474, 449);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(150, 200);
            this.characterImage.TabIndex = 1;
            this.characterImage.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Character_creator.Properties.Resources.WaveLevel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.characterImage);
            this.Controls.Add(this.monsterImage);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1800, 900);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.monsterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox monsterImage;
        private System.Windows.Forms.PictureBox characterImage;
    }
}
