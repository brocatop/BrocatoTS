using BrocatoTS.Classes;
using System;
using System.Windows.Forms;

namespace BrocatoTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Helper helper = new Helper();

        private void GoButton_Click(object sender, EventArgs e)
        {
            helper.GeneratePlanets(Convert.ToInt32(PlanetNumericUpDown.Value));
        }
    }
}
