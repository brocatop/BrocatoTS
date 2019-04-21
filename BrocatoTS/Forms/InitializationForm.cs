using System;
using System.Windows.Forms;

namespace BrocatoTS
{
    public partial class InitializationForm : Form
    {
        public InitializationForm()
        {
            InitializeComponent();
            label2.Text = FrequencyTrackBar.Value.ToString() + "%";
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
            this.Hide();
        }

        private void FrequencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = FrequencyTrackBar.Value.ToString() + "%";
        }
    }
}
