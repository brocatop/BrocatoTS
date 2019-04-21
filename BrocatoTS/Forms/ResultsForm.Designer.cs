namespace BrocatoTS
{
    partial class ResultsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ExportDataButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TryAgainButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportDataButton
            // 
            this.ExportDataButton.Location = new System.Drawing.Point(697, 528);
            this.ExportDataButton.Name = "ExportDataButton";
            this.ExportDataButton.Size = new System.Drawing.Size(128, 39);
            this.ExportDataButton.TabIndex = 6;
            this.ExportDataButton.Text = "Export Data";
            this.ExportDataButton.UseVisualStyleBackColor = true;
            this.ExportDataButton.Click += new System.EventHandler(this.ExportDataButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Most Efficient Distance:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(697, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 257);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Most Efficient Solution Was Found On Generation:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(207, 26);
            this.textBox3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Most Efficient Fitness Score:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 11;
            // 
            // ResultsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ResultsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ResultsChart.Legends.Add(legend3);
            this.ResultsChart.Location = new System.Drawing.Point(22, 23);
            this.ResultsChart.Name = "ResultsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Distance Traveled";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.ResultsChart.Series.Add(series3);
            this.ResultsChart.Size = new System.Drawing.Size(652, 572);
            this.ResultsChart.TabIndex = 12;
            this.ResultsChart.Text = "Summary of Simulation";
            // 
            // TryAgainButton
            // 
            this.TryAgainButton.Location = new System.Drawing.Point(887, 528);
            this.TryAgainButton.Name = "TryAgainButton";
            this.TryAgainButton.Size = new System.Drawing.Size(128, 39);
            this.TryAgainButton.TabIndex = 13;
            this.TryAgainButton.Text = "Try Again";
            this.TryAgainButton.UseVisualStyleBackColor = true;
            this.TryAgainButton.Click += new System.EventHandler(this.TryAgainButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1152, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(467, 550);
            this.dataGridView1.TabIndex = 14;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TryAgainButton);
            this.Controls.Add(this.ResultsChart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ExportDataButton);
            this.Name = "ResultsForm";
            this.Text = "Traveling Salesperson";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExportDataButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TryAgainButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

