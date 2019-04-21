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
            DataTable dt = FilloutDataTable();
            ResultsChart.DataSource = dt;
            ResultsChart.DataBind();
        }

        GeneticAlgorithm ga = new GeneticAlgorithm();
        Helper h = new Helper();
        Population p = new Population();
        Helper helper = new Helper();
        List<Planet> galaxy = new List<Planet>();
        List<Route> populationOfSolutions = new List<Route>();

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = FilloutDataTable();
            dataGridView1.DataSource = dt;
            //PopulateChart(dt);
        }

        private void PopulateChart(DataTable dt)
        {
            ResultsChart.Series.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i][1].ToString();
                ResultsChart.Series.Add(s);
                ResultsChart.Series[i].ChartType = SeriesChartType.Line;

                ResultsChart.Series[s].XValueMember = "generationCounter";
                ResultsChart.Series[s].YValueMembers = "shortestDistance";
            }
            ResultsChart.DataBind();
        }

        private void InitializePlanetsandRoutes(Chart chart)
        {
            galaxy = h.GeneratePlanets(InitializationForm.ValueForPlanets);
            populationOfSolutions = p.InitialPopulation(galaxy);
            DataTable dt = ga.Algorithm(InitializationForm.ValueForGenerations, populationOfSolutions);
            chart.DataSource = dt;
            chart.DataBind();
            //Need to add code to bind the data to the other parts of form... dt.Compute()?
        }

        public DataTable FilloutDataTable()
        {
            galaxy = h.GeneratePlanets(InitializationForm.ValueForPlanets);
            populationOfSolutions = p.InitialPopulation(galaxy);
            DataTable dt = ga.Algorithm(InitializationForm.ValueForGenerations, populationOfSolutions);

            return dt;
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

        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            InitializePlanetsandRoutes(ResultsChart);
        }
    }
}
