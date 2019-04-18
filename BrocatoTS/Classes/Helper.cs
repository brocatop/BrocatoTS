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


        public List<Planets> GeneratePlanets(int numberOfPlanets)
        {
            List<Planets> planets = new List<Planets>();

            Random r = new Random();

            //for i <= number of planets the user inputs
            for (int i = 0; i <= numberOfPlanets - 1; i++)
            {
                int x = r.Next(0, 500);
                int y = r.Next(0, 500);
                Planets p = new Planets(x, y, "Planet" + (i+1).ToString());
                if (PlanetChecker(p, planets) == false)
                {
                    //I will need to improve this later
                    p.XCoordinate = p.XCoordinate + 1;
                }
                planets.Add(p);
            }

            return planets;
        }

        //This method is meant to see if the planet generated is unique in the list of planets
        private bool PlanetChecker(Planets planet, List<Planets> planetsInSystem)
        {
            bool isUniquePlanet = false;
            var samePlanet = planetsInSystem.Where(p => p.XCoordinate == planet.XCoordinate && p.YCoordinate == planet.YCoordinate);
            if (samePlanet == null)
            {
                isUniquePlanet = true;
            }
            return isUniquePlanet;
        }


        //This method calculates the distance between all of the points on a route using the Pythagorean Theorem, returning the total once they have gone through the entire list
        public double CalculateDistance(List<Planets> planetRoute)
        {
            double distance = 0;
            double tempDistance;
            for (int i = 0; i <= planetRoute.Count - 2; i++)
            {
                //tempDistance calculates the initial a and b for the Pythagorean theorem
                tempDistance = ((planetRoute[i + 1].XCoordinate - planetRoute[i].XCoordinate) * (planetRoute[i + 1].XCoordinate - planetRoute[i].XCoordinate)
                    + (planetRoute[i + 1].YCoordinate - planetRoute[i].YCoordinate) * (planetRoute[i + 1].YCoordinate - planetRoute[i].YCoordinate));

                //Find the squareroute of tempDistance
                tempDistance = Math.Sqrt(tempDistance);

                //Append tempdistance to the running distance total
                distance += tempDistance;
            }
            return distance;
        }
    }
}
