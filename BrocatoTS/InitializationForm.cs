using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrocatoTS
{
    public partial class InitializationForm : Form
    {
        public InitializationForm()
        {
            InitializeComponent();
        }

        public static int ValueForPlanets;
        public static int ValueForGenerations;
        public static int ValueForMutationFrequency;

        private void InitializationForm_Load(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            ValueForPlanets = Convert.ToInt32(PlanetNumericUpDown.Value);
            ValueForGenerations = Convert.ToInt32(GenerationNumericUpDown.Value);
            ValueForMutationFrequency = Convert.ToInt32(FrequencyTrackBar.Value);

            ResultsForm rf = new ResultsForm();
            rf.Show();
        }
    }
}
