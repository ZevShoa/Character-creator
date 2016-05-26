namespace Character_creator
{
    partial class OptionsScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsScreen));
            this.optionsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.ProgressBar();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopChartLabel = new System.Windows.Forms.Label();
            this.buttonChartLabel = new System.Windows.Forms.Label();
            this.ResponseChartLabel = new System.Windows.Forms.Label();
            this.horizontalChartLine = new System.Windows.Forms.Label();
            this.verticalChartLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionsLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.ForeColor = System.Drawing.Color.White;
            this.optionsLabel.Location = new System.Drawing.Point(404, 137);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(243, 88);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "OPTIONS";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(988, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 63);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Control;
            this.menuButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 69);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "↩";
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // volumeBar
            // 
            this.volumeBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.volumeBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeBar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.volumeBar.Location = new System.Drawing.Point(383, 284);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(491, 38);
            this.volumeBar.TabIndex = 8;
            this.volumeBar.Value = 55;
            this.volumeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeBar_MouseDown);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.ForeColor = System.Drawing.Color.White;
            this.volumeLabel.Location = new System.Drawing.Point(201, 272);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(124, 50);
            this.volumeLabel.TabIndex = 9;
            this.volumeLabel.Text = "Volume:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(257, 442);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(0, 0);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // TopChartLabel
            // 
            this.TopChartLabel.AutoSize = true;
            this.TopChartLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopChartLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopChartLabel.ForeColor = System.Drawing.Color.White;
            this.TopChartLabel.Location = new System.Drawing.Point(201, 409);
            this.TopChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopChartLabel.Name = "TopChartLabel";
            this.TopChartLabel.Size = new System.Drawing.Size(573, 50);
            this.TopChartLabel.TabIndex = 12;
            this.TopChartLabel.Text = "Controls:       Button                   Response";
            // 
            // buttonChartLabel
            // 
            this.buttonChartLabel.BackColor = System.Drawing.Color.Transparent;
            this.buttonChartLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChartLabel.ForeColor = System.Drawing.Color.White;
            this.buttonChartLabel.Location = new System.Drawing.Point(374, 481);
            this.buttonChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonChartLabel.Name = "buttonChartLabel";
            this.buttonChartLabel.Size = new System.Drawing.Size(129, 212);
            this.buttonChartLabel.TabIndex = 13;
            this.buttonChartLabel.Text = "\"A\" Key \"D\" Key Space Enter";
            // 
            // ResponseChartLabel
            // 
            this.ResponseChartLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResponseChartLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseChartLabel.ForeColor = System.Drawing.Color.White;
            this.ResponseChartLabel.Location = new System.Drawing.Point(527, 481);
            this.ResponseChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResponseChartLabel.Name = "ResponseChartLabel";
            this.ResponseChartLabel.Size = new System.Drawing.Size(347, 212);
            this.ResponseChartLabel.TabIndex = 14;
            this.ResponseChartLabel.Text = "Moves The Player Left Moves The Player Right Toggles Between Battle Options Selec" +
    "ts Battle Options";
            // 
            // horizontalChartLine
            // 
            this.horizontalChartLine.BackColor = System.Drawing.Color.White;
            this.horizontalChartLine.Location = new System.Drawing.Point(379, 459);
            this.horizontalChartLine.Name = "horizontalChartLine";
            this.horizontalChartLine.Size = new System.Drawing.Size(484, 10);
            this.horizontalChartLine.TabIndex = 15;
            // 
            // verticalChartLine
            // 
            this.verticalChartLine.BackColor = System.Drawing.Color.White;
            this.verticalChartLine.Location = new System.Drawing.Point(491, 419);
            this.verticalChartLine.Name = "verticalChartLine";
            this.verticalChartLine.Size = new System.Drawing.Size(12, 263);
            this.verticalChartLine.TabIndex = 16;
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.verticalChartLine);
            this.Controls.Add(this.horizontalChartLine);
            this.Controls.Add(this.ResponseChartLabel);
            this.Controls.Add(this.buttonChartLabel);
            this.Controls.Add(this.TopChartLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OptionsScreen";
            this.Size = new System.Drawing.Size(1050, 769);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OptionsScreen_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ProgressBar volumeBar;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label TopChartLabel;
        private System.Windows.Forms.Label buttonChartLabel;
        private System.Windows.Forms.Label ResponseChartLabel;
        private System.Windows.Forms.Label horizontalChartLine;
        private System.Windows.Forms.Label verticalChartLine;
    }
}
