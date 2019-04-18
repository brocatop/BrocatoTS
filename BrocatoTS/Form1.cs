using BrocatoTS.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrocatoTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {          
            InitializeComponent();
            PlanetTest();
        }

        Helper helper = new Helper();

        private void PlanetTest()
        {
            Helper helper = new Helper();
            List<Planets> planets = helper.GeneratePlanets(4);
            foreach (Planets p in planets)
            {
                Console.WriteLine(p.Name.ToString() + " X: " + p.XCoordinate.ToString() +" Y: " +p.YCoordinate.ToString());
            }

            double distance = helper.CalculateDistance(planets);

            Console.WriteLine(distance.ToString());
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            helper.GeneratePlanets(Convert.ToInt32(PlanetNumericUpDown.Value));
        }
    }
}
