using BrocatoTS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            DataTable dt = FilloutDataTableWithResults();
            GeneticAlgorithm ga = new GeneticAlgorithm();
            dataGridView1.DataSource = dt;
            PopulateChart(dt);
            dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Ascending);
            label3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label5.Text = ga.CalculateFitness(Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value)).ToString();
            label6.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        GeneticAlgorithm ga = new GeneticAlgorithm();
        Helper h = new Helper();
        Population p = new Population();
        Helper helper = new Helper();
        List<Planet> galaxy = new List<Planet>();
        List<Route> populationOfSolutions = new List<Route>();

        private void ResultsForm_Load(object sender, EventArgs e)
        {

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



        //Restarts the application
        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    ResultsChart.SaveImage("~\\Results\\ResultsSummary" + DateTime.Now.ToShortTimeString(), ChartImageFormat.Png);
                }
                /*
                else if (tabControl1.SelectedIndex == 1)
                {

                }
                */
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        public DataTable FilloutDataTableWithResults()
        {
            galaxy = h.GeneratePlanets(InitializationForm.ValueForPlanets);
            populationOfSolutions = p.InitialPopulation(galaxy);
            DataTable dt = ga.Algorithm(InitializationForm.ValueForGenerations, InitializationForm.ValueForMutationFrequency, populationOfSolutions);
            return dt;
        }

    }
}
