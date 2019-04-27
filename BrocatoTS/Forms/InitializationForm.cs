using BrocatoTS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace BrocatoTS
{
    public partial class InitializationForm : Form
    {
        public InitializationForm()
        {
            InitializeComponent();
            //Allows the value of the trackbar to be visualized
            label2.Text = FrequencyTrackBar.Value.ToString() + "%";
        }

        //Objects to call upon methods to allow the program to be used
        Helper h = new Helper();
        GeneticAlgorithm ga = new GeneticAlgorithm();


        //Static variables to be used for the next form and the genetic algorithm
        public static int ValueForPlanets;
        public static int ValueForGenerations;
        public static int ValueForMutationFrequency;
        public static DataTable ResultsDataTable;

        //Opens the results form and appends the values the user inputted to the static variables
        private void GoButton_Click(object sender, EventArgs e)
        {
            ValueForPlanets = Convert.ToInt32(PlanetNumericUpDown.Value);
            ValueForGenerations = Convert.ToInt32(GenerationNumericUpDown.Value);
            ValueForMutationFrequency = Convert.ToInt32(FrequencyTrackBar.Value);

            ResultsForm rf = new ResultsForm();
            rf.Show();
            this.Hide();
        }

        //Updates the frequency label with the current value
        private void FrequencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = FrequencyTrackBar.Value.ToString() + "%";
        }
    }
}
