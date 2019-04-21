using BrocatoTS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BrocatoTS
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {          
            InitializeComponent();
            InitializePlanetsandRoutes(ResultsChart);
        }

        GeneticAlgorithm ga = new GeneticAlgorithm();
        Helper h = new Helper();
        Population p = new Population();
        Helper helper = new Helper();

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            //InitializePlanetsandRoutes(ResultsChart);
        }

        private void InitializePlanetsandRoutes(Chart chart)
        {
            List<Planet> galaxy = h.GeneratePlanets(InitializationForm.ValueForPlanets);
            List<Route> populationOfSolutions = p.InitialPopulation(galaxy);
            DataTable dt = ga.Algorithm(InitializationForm.ValueForGenerations, populationOfSolutions);
            chart.DataSource = dt;
            //Need to add code to bind the data to the other parts of form... dt.Compute()?
        }

        /*
        private void PlanetTest()
        {
            Helper helper = new Helper();
            List<Planet> planets = helper.GeneratePlanets(InitializationForm.ValueForPlanets);
            foreach (Planet p in planets)
            {
                Console.WriteLine(p.Name.ToString() + " X: " + p.XCoordinate.ToString() +" Y: " +p.YCoordinate.ToString());
            }

            double distance = helper.CalculateDistance(planets);

            Console.WriteLine(distance.ToString());
        }
        */

        //Restarts the application
        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
