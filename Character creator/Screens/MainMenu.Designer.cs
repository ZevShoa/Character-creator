namespace Character_creator
{
    partial class MainMenu
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.updatesLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(401, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(161, 59);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "OmiCron";
            // 
            // updatesLabel
            // 
            this.updatesLabel.BackColor = System.Drawing.Color.White;
            this.updatesLabel.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesLabel.Location = new System.Drawing.Point(233, 120);
            this.updatesLabel.Name = "updatesLabel";
            this.updatesLabel.Size = new System.Drawing.Size(478, 351);
            this.updatesLabel.TabIndex = 1;
            this.updatesLabel.Text = "News Upates:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(691, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.BackColor = System.Drawing.SystemColors.Control;
            this.newUserButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.ForeColor = System.Drawing.Color.Black;
            this.newUserButton.Location = new System.Drawing.Point(6, 31);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(201, 62);
            this.newUserButton.TabIndex = 3;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = false;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.SystemColors.Control;
            this.optionsButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.ForeColor = System.Drawing.Color.Black;
            this.optionsButton.Location = new System.Drawing.Point(3, 265);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(204, 62);
            this.optionsButton.TabIndex = 4;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(3, 109);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(204, 62);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.SystemColors.Control;
            this.leaderboardButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.ForeColor = System.Drawing.Color.Black;
            this.leaderboardButton.Location = new System.Drawing.Point(3, 187);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(204, 62);
            this.leaderboardButton.TabIndex = 6;
            this.leaderboardButton.Text = "Leaderboard";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updatesLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(750, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label updatesLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button leaderboardButton;
    }
}
