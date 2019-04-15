using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrocatoTS.Classes
{
    class Planets
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        string Name { get; set; }

        public Planets(int x, int y, string name)
        {
            XCoordinate = x;
            YCoordinate = y;
            Name = name;
        }

        private void GeneratePlanets()
        {
            List<Planets> planets = new List<Planets>();

            //for i <= number of planets the user inputs
            for (int i = 0; i <= 100; i++)
            {
                Planets p = new Planets(0, 0, "Planets" + i.ToString());
                if(PlanetChecker(p,planets) == false)
                {
                     //Make it unique
                }
                planets.Add(p);
            }
        }

        private bool PlanetChecker(Planets planet, List<Planets> planetsInSystem)
        {
            bool isUniquePlanet = false;
            var samePlanet = planetsInSystem.Where(p => p.XCoordinate == planet.XCoordinate && p.YCoordinate == planet.YCoordinate);
            if(samePlanet == null)
            {
                isUniquePlanet = true;
            }
            return isUniquePlanet;
        }

        private Tuple<int, int> DistanceBetweenPlanets(Planets p1, Planets p2)
        {
            int xDistance = p1.XCoordinate - p2.XCoordinate;
            int yDistance = p1.YCoordinate - p2.YCoordinate;

            return Tuple.Create(xDistance, yDistance);
        }
    }
}
