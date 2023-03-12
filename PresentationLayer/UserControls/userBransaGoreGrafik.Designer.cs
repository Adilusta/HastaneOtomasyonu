namespace PresentationLayer.UserControls
{
    partial class userBransaGoreGrafik
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartBransaGoreHasta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBransaGoreHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBransaGoreHasta
            // 
            this.chartBransaGoreHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.chartBransaGoreHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartBransaGoreHasta.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartBransaGoreHasta.BorderlineWidth = 3;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartBransaGoreHasta.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartBransaGoreHasta.Legends.Add(legend1);
            this.chartBransaGoreHasta.Location = new System.Drawing.Point(47, 32);
            this.chartBransaGoreHasta.Name = "chartBransaGoreHasta";
            this.chartBransaGoreHasta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartBransaGoreHasta.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Purple;
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 5;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBransaGoreHasta.Series.Add(series1);
            this.chartBransaGoreHasta.Size = new System.Drawing.Size(743, 375);
            this.chartBransaGoreHasta.TabIndex = 13;
            this.chartBransaGoreHasta.Text = "BRANŞLAR";
            this.chartBransaGoreHasta.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "BRANŞLARA GÖRE HASTA SAYILARI";
            this.chartBransaGoreHasta.Titles.Add(title1);
            // 
            // userBransaGoreGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.chartBransaGoreHasta);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.Name = "userBransaGoreGrafik";
            this.Size = new System.Drawing.Size(855, 445);
            this.Load += new System.EventHandler(this.userBransaGoreGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBransaGoreHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBransaGoreHasta;
    }
}
