using BrocatoTS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BrocatoTS
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {          
            InitializeComponent();
        }

        GeneticAlgorithm ga = new GeneticAlgorithm();
        Helper h = new Helper();
        Population p = new Population();
        Helper helper = new Helper();
        List<Planet> galaxy = new List<Planet>();
        List<Route> populationOfSolutions = new List<Route>();

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = FilloutDataTableWithResults();
            dataGridView1.DataSource = dt;
            PopulateChart(dt);
        }

        private void PopulateChart(DataTable dt)
        {
            ResultsChart.DataSource = dt;
            List<double> yDistances = dt.AsEnumerable().Select(x => x.Field<double>(1)).ToList();
            List<int> xGenerations = dt.AsEnumerable().Select(x => x.Field<int>(0)).ToList();
            ResultsChart.Width = 652;
            ResultsChart.Height = 572;

            Series results = new Series
            {
                Name = "Results",
                Color = Color.Red,
                BorderColor = Color.Black,
                ChartType = SeriesChartType.Line,
                BorderDashStyle = ChartDashStyle.Solid,
                BorderWidth = 1,
                XValueMember = dt.Columns[0].ToString(),
                YValueMembers = dt.Columns[1].ToString(),
                Font = new Font("Times New Roman", 8.0f),
                BackSecondaryColor = Color.White,
                LabelForeColor = Color.White
            };
            ResultsChart.Series.Add(results);

            ResultsChart.DataBind();
        }

        public DataTable FilloutDataTableWithResults()
        {
            galaxy = h.GeneratePlanets(InitializationForm.ValueForPlanets);
            populationOfSolutions = p.InitialPopulation(galaxy);
            DataTable dt = ga.Algorithm(InitializationForm.ValueForGenerations, populationOfSolutions);

            return dt;
        }

        //Restarts the application
        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void ExportDataButton_Click(object sender, EventArgs e)
        {

        }
    }
}
