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
            this.ExportDataButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TryAgainButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.charttab = new System.Windows.Forms.TabPage();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabletab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.charttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            this.tabletab.SuspendLayout();
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(697, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 471);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Most Efficient Fitness Score:";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(13, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 471);
            this.panel1.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.charttab);
            this.tabControl1.Controls.Add(this.tabletab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 471);
            this.tabControl1.TabIndex = 16;
            // 
            // charttab
            // 
            this.charttab.Controls.Add(this.ResultsChart);
            this.charttab.Location = new System.Drawing.Point(4, 29);
            this.charttab.Name = "charttab";
            this.charttab.Padding = new System.Windows.Forms.Padding(3);
            this.charttab.Size = new System.Drawing.Size(623, 438);
            this.charttab.TabIndex = 0;
            this.charttab.Text = "Results Chart";
            this.charttab.UseVisualStyleBackColor = true;
            // 
            // ResultsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ResultsChart.ChartAreas.Add(chartArea3);
            this.ResultsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.ResultsChart.Legends.Add(legend3);
            this.ResultsChart.Location = new System.Drawing.Point(3, 3);
            this.ResultsChart.Name = "ResultsChart";
            this.ResultsChart.Size = new System.Drawing.Size(617, 432);
            this.ResultsChart.TabIndex = 12;
            this.ResultsChart.Text = "Summary of Simulation";
            // 
            // tabletab
            // 
            this.tabletab.Controls.Add(this.dataGridView1);
            this.tabletab.Location = new System.Drawing.Point(4, 29);
            this.tabletab.Name = "tabletab";
            this.tabletab.Padding = new System.Windows.Forms.Padding(3);
            this.tabletab.Size = new System.Drawing.Size(623, 438);
            this.tabletab.TabIndex = 1;
            this.tabletab.Text = "Results Table";
            this.tabletab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(617, 432);
            this.dataGridView1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TryAgainButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ExportDataButton);
            this.Name = "ResultsForm";
            this.Text = "Traveling Salesperson";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.charttab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).EndInit();
            this.tabletab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExportDataButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TryAgainButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage charttab;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsChart;
        private System.Windows.Forms.TabPage tabletab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

