using System;
using System.Collections.Generic;
using System.Linq;

namespace BrocatoTS.Classes
{
    class Helper
    {
        public Helper()
        {

        }

        public List<Planet> GeneratePlanets(int numberOfPlanets)
        {
            List<Planet> planets = new List<Planet>();

            Random r = new Random(Guid.NewGuid().GetHashCode());

            //for i <= number of planets the user inputs
            for (int i = 0; i <= numberOfPlanets - 1; i++)
            {
                int x = r.Next(0, 500);
                int y = r.Next(0, 500);
                int z = r.Next(0, 500);
                Planet p = new Planet(x, y, z, "Planet" + (i + 1).ToString());

                //I will need to look into this later
                while (PlanetChecker(p, planets) == true)
                {
                    z = r.Next(0, 500);
                }

                planets.Add(p);
            }

            return planets;
        }

        //This method is meant to see if the planet generated is unique in the list of planets
        private bool PlanetChecker(Planet planet, List<Planet> planetsInSystem)
        {
            bool isUniquePlanet = false;
            var samePlanet = planetsInSystem.Where(p => p.XCoordinate == planet.XCoordinate && p.YCoordinate == planet.YCoordinate);
            if (samePlanet == null)
            {
                isUniquePlanet = true;
            }
            return isUniquePlanet;
        }


        //This method calculates the distance between all of the points on a route using the Euclidean distance formula, 
        //returning the total once they have gone through the entire list
        public double CalculateDistance(List<Planet> planetRoute)
        {
            double distance = 0;
            double tempDistance;
            for (int i = 0; i <= planetRoute.Count - 2; i++)
            {
                int x = planetRoute[i + 1].XCoordinate - planetRoute[i].XCoordinate;
                int y = planetRoute[i + 1].YCoordinate - planetRoute[i].YCoordinate;
                int z = planetRoute[i + 1].ZCoordinate - planetRoute[i].ZCoordinate;

                tempDistance = Math.Sqrt(x * x + y * y + z * z);
                //Append tempdistance to the running distance total
                distance += tempDistance;
            }
            return distance;
        }


    }
}
