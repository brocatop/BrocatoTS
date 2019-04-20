using BrocatoTS.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrocatoTS
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {          
            InitializeComponent();
            PlanetTest();
        }
        GeneticAlgorithm ga = new GeneticAlgorithm();

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            ResultsChart.DataSource = ga.Algorithm(InitializationForm.ValueForPlanets);
        }

        Helper helper = new Helper();

        private void PlanetTest()
        {
            Helper helper = new Helper();
            List<Planets> planets = helper.GeneratePlanets(InitializationForm.ValueForPlanets);
            foreach (Planets p in planets)
            {
                Console.WriteLine(p.Name.ToString() + " X: " + p.XCoordinate.ToString() +" Y: " +p.YCoordinate.ToString());
            }

            double distance = helper.CalculateDistance(planets);

            Console.WriteLine(distance.ToString());
        }
    }
}
