namespace BrocatoTS
{
    partial class InitializationForm
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
            this.GoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PlanetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(684, 198);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 42);
            this.GoButton.TabIndex = 16;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number of Planets:";
            // 
            // PlanetNumericUpDown
            // 
            this.PlanetNumericUpDown.Location = new System.Drawing.Point(23, 181);
            this.PlanetNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PlanetNumericUpDown.Name = "PlanetNumericUpDown";
            this.PlanetNumericUpDown.ReadOnly = true;
            this.PlanetNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.PlanetNumericUpDown.TabIndex = 17;
            this.PlanetNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mutation Frequency:";
            // 
            // GenerationNumericUpDown
            // 
            this.GenerationNumericUpDown.Location = new System.Drawing.Point(216, 177);
            this.GenerationNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.GenerationNumericUpDown.Name = "GenerationNumericUpDown";
            this.GenerationNumericUpDown.ReadOnly = true;
            this.GenerationNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.GenerationNumericUpDown.TabIndex = 19;
            this.GenerationNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // FrequencyTrackBar
            // 
            this.FrequencyTrackBar.Location = new System.Drawing.Point(432, 171);
            this.FrequencyTrackBar.Maximum = 100;
            this.FrequencyTrackBar.Minimum = 1;
            this.FrequencyTrackBar.Name = "FrequencyTrackBar";
            this.FrequencyTrackBar.Size = new System.Drawing.Size(207, 69);
            this.FrequencyTrackBar.TabIndex = 21;
            this.FrequencyTrackBar.Value = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Number of Generations:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Please determine the settings for this run";
            // 
            // InitializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlanetNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenerationNumericUpDown);
            this.Controls.Add(this.FrequencyTrackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GoButton);
            this.Name = "InitializationForm";
            this.Text = "Program Intialization";
            this.Load += new System.EventHandler(this.InitializationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PlanetNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown GenerationNumericUpDown;
        private System.Windows.Forms.TrackBar FrequencyTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}