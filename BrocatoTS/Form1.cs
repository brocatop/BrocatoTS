using BrocatoTS.Classes;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GeneratePlanets()
        {
            List<Planets> planets = new List<Planets>();

            //for i <= number of cities the user inputs
            for(int i = 0; i <= 0; i++)
            {
                Planets p = new Planets(0, 0, "Planets" + i.ToString());
                planets.Add(p);
            }
        }
    }
}
