namespace PresentationLayer.UserControls
{
    partial class userDrGoreHastaGrafik
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
            this.chartDoktoraGoreHasta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoktoraGoreHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoktoraGoreHasta
            // 
            this.chartDoktoraGoreHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.chartDoktoraGoreHasta.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartDoktoraGoreHasta.BorderlineWidth = 3;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -50;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartDoktoraGoreHasta.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartDoktoraGoreHasta.Legends.Add(legend1);
            this.chartDoktoraGoreHasta.Location = new System.Drawing.Point(47, 32);
            this.chartDoktoraGoreHasta.Name = "chartDoktoraGoreHasta";
            this.chartDoktoraGoreHasta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            this.chartDoktoraGoreHasta.Series.Add(series1);
            this.chartDoktoraGoreHasta.Size = new System.Drawing.Size(743, 375);
            this.chartDoktoraGoreHasta.TabIndex = 11;
            this.chartDoktoraGoreHasta.Text = "chart1";
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Doktorlar";
            title1.Text = "DOKTORLARA GÖRE HASTA SAYISI";
            this.chartDoktoraGoreHasta.Titles.Add(title1);
            // 
            // userDrGoreHastaGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.chartDoktoraGoreHasta);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.Name = "userDrGoreHastaGrafik";
            this.Size = new System.Drawing.Size(855, 445);
            this.Load += new System.EventHandler(this.userDrGoreHastaGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoktoraGoreHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoktoraGoreHasta;
    }
}
