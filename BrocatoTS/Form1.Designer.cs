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
            ((System.ComponentModel.ISupportInitialize)(this.PlanetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanetNumericUpDown
            // 
            this.PlanetNumericUpDown.Location = new System.Drawing.Point(665, 142);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 636);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.PlanetNumericUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlanetNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PlanetNumericUpDown;
        private System.Windows.Forms.Button GoButton;
    }
}

