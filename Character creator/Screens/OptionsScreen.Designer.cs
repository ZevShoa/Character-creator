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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopChartLabel = new System.Windows.Forms.Label();
            this.buttonChartLabel = new System.Windows.Forms.Label();
            this.ResponseChartLabel = new System.Windows.Forms.Label();
            this.horizontalChartLine = new System.Windows.Forms.Label();
            this.verticalChartLine = new System.Windows.Forms.Label();
            this.howToPlayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionsLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.ForeColor = System.Drawing.Color.White;
            this.optionsLabel.Location = new System.Drawing.Point(334, 122);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(345, 88);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Instructions";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(987, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 62);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Control;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(3, 2);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 69);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "↩";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(205, 512);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.TopChartLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopChartLabel.ForeColor = System.Drawing.Color.White;
            this.TopChartLabel.Location = new System.Drawing.Point(177, 488);
            this.TopChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopChartLabel.Name = "TopChartLabel";
            this.TopChartLabel.Size = new System.Drawing.Size(428, 44);
            this.TopChartLabel.TabIndex = 12;
            this.TopChartLabel.Text = "Controls:       Button         Response";
            // 
            // buttonChartLabel
            // 
            this.buttonChartLabel.BackColor = System.Drawing.Color.Transparent;
            this.buttonChartLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChartLabel.ForeColor = System.Drawing.Color.White;
            this.buttonChartLabel.Location = new System.Drawing.Point(323, 552);
            this.buttonChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonChartLabel.Name = "buttonChartLabel";
            this.buttonChartLabel.Size = new System.Drawing.Size(129, 143);
            this.buttonChartLabel.TabIndex = 13;
            this.buttonChartLabel.Text = "\"A\" Key \"D\" Key Space";
            // 
            // ResponseChartLabel
            // 
            this.ResponseChartLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResponseChartLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseChartLabel.ForeColor = System.Drawing.Color.White;
            this.ResponseChartLabel.Location = new System.Drawing.Point(475, 552);
            this.ResponseChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResponseChartLabel.Name = "ResponseChartLabel";
            this.ResponseChartLabel.Size = new System.Drawing.Size(346, 143);
            this.ResponseChartLabel.TabIndex = 14;
            this.ResponseChartLabel.Text = "Moves The Player Left Moves The Player Right Pauses The Game";
            // 
            // horizontalChartLine
            // 
            this.horizontalChartLine.BackColor = System.Drawing.Color.White;
            this.horizontalChartLine.Location = new System.Drawing.Point(330, 528);
            this.horizontalChartLine.Name = "horizontalChartLine";
            this.horizontalChartLine.Size = new System.Drawing.Size(483, 9);
            this.horizontalChartLine.TabIndex = 15;
            // 
            // verticalChartLine
            // 
            this.verticalChartLine.BackColor = System.Drawing.Color.White;
            this.verticalChartLine.Location = new System.Drawing.Point(437, 488);
            this.verticalChartLine.Name = "verticalChartLine";
            this.verticalChartLine.Size = new System.Drawing.Size(15, 207);
            this.verticalChartLine.TabIndex = 16;
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToPlayLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayLabel.ForeColor = System.Drawing.Color.White;
            this.howToPlayLabel.Location = new System.Drawing.Point(25, 210);
            this.howToPlayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(957, 278);
            this.howToPlayLabel.TabIndex = 17;
            this.howToPlayLabel.Text = resources.GetString("howToPlayLabel.Text");
            this.howToPlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.verticalChartLine);
            this.Controls.Add(this.horizontalChartLine);
            this.Controls.Add(this.ResponseChartLabel);
            this.Controls.Add(this.buttonChartLabel);
            this.Controls.Add(this.TopChartLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OptionsScreen";
            this.Size = new System.Drawing.Size(1050, 769);
            this.Load += new System.EventHandler(this.OptionsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label TopChartLabel;
        private System.Windows.Forms.Label buttonChartLabel;
        private System.Windows.Forms.Label ResponseChartLabel;
        private System.Windows.Forms.Label horizontalChartLine;
        private System.Windows.Forms.Label verticalChartLine;
        private System.Windows.Forms.Label howToPlayLabel;
    }
}
