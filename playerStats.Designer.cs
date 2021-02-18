namespace CLEAVELAND_ONYANGO_AWD_2019
{
    partial class playerStats
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerStats));
            this.scoreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnloadchart = new System.Windows.Forms.Button();
            this.pnlplayerchart = new System.Windows.Forms.GroupBox();
            this.pnltable = new System.Windows.Forms.GroupBox();
            this.dbPlayerScores = new System.Windows.Forms.DataGridView();
            this.btnloadtable = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreChart)).BeginInit();
            this.pnlplayerchart.SuspendLayout();
            this.pnltable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbPlayerScores)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreChart
            // 
            chartArea1.Name = "ChartArea1";
            this.scoreChart.ChartAreas.Add(chartArea1);
            legend1.Name = "PLAYERS";
            this.scoreChart.Legends.Add(legend1);
            this.scoreChart.Location = new System.Drawing.Point(6, 19);
            this.scoreChart.Name = "scoreChart";
            this.scoreChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "PLAYERS";
            series1.Name = "Scores";
            this.scoreChart.Series.Add(series1);
            this.scoreChart.Size = new System.Drawing.Size(367, 355);
            this.scoreChart.TabIndex = 0;
            this.scoreChart.Text = "scoreChart";
            title1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "PLAYER SCORES PER GAME";
            title1.Text = "PLAYER SCORES PER GAME";
            this.scoreChart.Titles.Add(title1);
            // 
            // btnloadchart
            // 
            this.btnloadchart.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadchart.Location = new System.Drawing.Point(122, 417);
            this.btnloadchart.Name = "btnloadchart";
            this.btnloadchart.Size = new System.Drawing.Size(155, 40);
            this.btnloadchart.TabIndex = 1;
            this.btnloadchart.Text = "LOAD CHART";
            this.btnloadchart.UseVisualStyleBackColor = true;
            this.btnloadchart.Click += new System.EventHandler(this.btnloadchart_Click);
            // 
            // pnlplayerchart
            // 
            this.pnlplayerchart.Controls.Add(this.scoreChart);
            this.pnlplayerchart.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlplayerchart.Location = new System.Drawing.Point(12, 12);
            this.pnlplayerchart.Name = "pnlplayerchart";
            this.pnlplayerchart.Size = new System.Drawing.Size(379, 388);
            this.pnlplayerchart.TabIndex = 2;
            this.pnlplayerchart.TabStop = false;
            this.pnlplayerchart.Text = "Player Chart";
            // 
            // pnltable
            // 
            this.pnltable.Controls.Add(this.dbPlayerScores);
            this.pnltable.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltable.Location = new System.Drawing.Point(397, 12);
            this.pnltable.Name = "pnltable";
            this.pnltable.Size = new System.Drawing.Size(363, 388);
            this.pnltable.TabIndex = 3;
            this.pnltable.TabStop = false;
            this.pnltable.Text = "Leadership Board";
            // 
            // dbPlayerScores
            // 
            this.dbPlayerScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbPlayerScores.Location = new System.Drawing.Point(6, 24);
            this.dbPlayerScores.Name = "dbPlayerScores";
            this.dbPlayerScores.Size = new System.Drawing.Size(349, 350);
            this.dbPlayerScores.TabIndex = 4;
            // 
            // btnloadtable
            // 
            this.btnloadtable.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadtable.Location = new System.Drawing.Point(524, 417);
            this.btnloadtable.Name = "btnloadtable";
            this.btnloadtable.Size = new System.Drawing.Size(155, 40);
            this.btnloadtable.TabIndex = 4;
            this.btnloadtable.Text = "LOAD TABLE";
            this.btnloadtable.UseVisualStyleBackColor = true;
            this.btnloadtable.Click += new System.EventHandler(this.btnloadtable_Click);
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(376, 414);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 50);
            this.btnback.TabIndex = 65;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // playerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 469);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnloadtable);
            this.Controls.Add(this.pnltable);
            this.Controls.Add(this.pnlplayerchart);
            this.Controls.Add(this.btnloadchart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "playerStats";
            this.ShowIcon = false;
            this.Text = "playerStatistics";
            this.Load += new System.EventHandler(this.playerStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreChart)).EndInit();
            this.pnlplayerchart.ResumeLayout(false);
            this.pnltable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbPlayerScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart scoreChart;
        private System.Windows.Forms.Button btnloadchart;
        private System.Windows.Forms.GroupBox pnlplayerchart;
        private System.Windows.Forms.GroupBox pnltable;
        private System.Windows.Forms.DataGridView dbPlayerScores;
        private System.Windows.Forms.Button btnloadtable;
        private System.Windows.Forms.Button btnback;
    }
}