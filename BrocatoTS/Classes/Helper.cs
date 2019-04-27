using System;
using System.Collections.Generic;
using System.Linq;

namespace BrocatoTS.Classes
{
    //The purpose of this class is to provide helper functions that assist in the simulation of the traveling salesman problem
    class Helper
    {
        //Default constructor
        public Helper()
        {

        }

        //Generates a galaxy of planets based off of the user's input of planets
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

                //Checks to see if the planet is unique
                while (PlanetChecker(p, planets) == true)
                {
                    z = r.Next(0, 500);
                }

                planets.Add(p);
            }

            return planets;
        }

        //Shuffles the list of planets into a random order, to be used for creating initial populations
        public List<Planet> ShufflePlanets(List<Planet> p)
        {
            //Various variables
            List<Planet> planets = p;
            List<int> ExcludedIndexes = new List<int>();
            int planetCount = p.Count;
            Random r = new Random(Guid.NewGuid().GetHashCode());

            //Cycles through all of the planets and swaps them with another
            for (int i = 0; i <= planetCount - 1; i++)
            {
                //Gets the swapping index
                int swappingIndex = r.Next(0, planetCount);

                //If the swap has been done already at the index, give another index
                if (ExcludedIndexes.Contains(swappingIndex))
                {
                    swappingIndex = r.Next(0, planetCount);
                }
                else
                {
                    //Swaps the planets, copies the first index, writes over the first with the second, and then writes over the second with the temp
                    ExcludedIndexes.Add(swappingIndex);
                    Planet tempPlanet = planets[swappingIndex];
                    planets[swappingIndex] = planets[i];
                    planets[i] = tempPlanet;
                }
            }

            return planets;
        }

        //This method is meant to see if the planet generated is unique in the list of planets
        private bool PlanetChecker(Planet planet, List<Planet> planetsInSystem)
        {
            bool isUniquePlanet = false;
            //Using linq, it tries to find the planet in the list
            var samePlanet = planetsInSystem.Where(p => p.XCoordinate == planet.XCoordinate && p.YCoordinate == planet.YCoordinate);
            if (samePlanet == null)
            {
                isUniquePlanet = true;
            }
            return isUniquePlanet;
        }


        //This method calculates the distance between all of the points on a route using the Euclidean distance formula, 
        //returning the total once they have gone through the entire list
        //THe code was inspired by a solution provided on stackoverflow:
        // https://stackoverflow.com/questions/8914669/algorithm-for-calculating-a-distance-between-2-3-dimensional-points
        public double CalculateDistance(List<Planet> planetRoute)
        {
            double distance = 0;
            double tempDistance;
            //Searches through the route, calculating the euclidian distance from one planet to the next, cycling through. Appends the distance
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
