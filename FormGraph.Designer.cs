namespace MetrixExtract
{
    partial class FormGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChtMetrics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CboChartType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChtMetrics)).BeginInit();
            this.SuspendLayout();
            // 
            // ChtMetrics
            // 
            chartArea2.Name = "ChartArea1";
            this.ChtMetrics.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChtMetrics.Legends.Add(legend2);
            this.ChtMetrics.Location = new System.Drawing.Point(12, 12);
            this.ChtMetrics.Name = "ChtMetrics";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChtMetrics.Series.Add(series2);
            this.ChtMetrics.Size = new System.Drawing.Size(818, 536);
            this.ChtMetrics.TabIndex = 3;
            this.ChtMetrics.Text = "Chart for Metrics";
            // 
            // CboChartType
            // 
            this.CboChartType.FormattingEnabled = true;
            this.CboChartType.Items.AddRange(new object[] {
            "Bar",
            "Pie",
            "Line"});
            this.CboChartType.Location = new System.Drawing.Point(836, 12);
            this.CboChartType.Name = "CboChartType";
            this.CboChartType.Size = new System.Drawing.Size(77, 21);
            this.CboChartType.TabIndex = 4;
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 562);
            this.Controls.Add(this.CboChartType);
            this.Controls.Add(this.ChtMetrics);
            this.Name = "FormGraph";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.ChtMetrics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart ChtMetrics;
        internal System.Windows.Forms.ComboBox CboChartType;
    }
}