namespace BrocatoTS
{
    partial class Form1
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
            this.PlanetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerationsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanetNumericUpDown
            // 
            this.PlanetNumericUpDown.Location = new System.Drawing.Point(538, 133);
            this.PlanetNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PlanetNumericUpDown.Name = "PlanetNumericUpDown";
            this.PlanetNumericUpDown.ReadOnly = true;
            this.PlanetNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.PlanetNumericUpDown.TabIndex = 0;
            this.PlanetNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(641, 539);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(128, 39);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Planets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Generations:";
            // 
            // GenerationsNumericUpDown
            // 
            this.GenerationsNumericUpDown.Location = new System.Drawing.Point(538, 219);
            this.GenerationsNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.GenerationsNumericUpDown.Name = "GenerationsNumericUpDown";
            this.GenerationsNumericUpDown.ReadOnly = true;
            this.GenerationsNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.GenerationsNumericUpDown.TabIndex = 3;
            this.GenerationsNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 544);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerationsNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.PlanetNumericUpDown);
            this.Name = "Form1";
            this.Text = "Traveling Salesperson";
            ((System.ComponentModel.ISupportInitialize)(this.PlanetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PlanetNumericUpDown;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GenerationsNumericUpDown;
        private System.Windows.Forms.Panel panel1;
    }
}

