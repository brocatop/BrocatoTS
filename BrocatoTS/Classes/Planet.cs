using System;
using System.Collections.Generic;

namespace BrocatoTS.Classes
{
    class Planet
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int ZCoordinate { get; set; }
        public string Name { get; set; }

        public Planet(int x, int y, int z, string name)
        {
            XCoordinate = x;
            YCoordinate = y;
            ZCoordinate = z;
            Name = name;
        }

        public Planet()
        {

        }

        //Shuffles the list of planets into a random order, to be used for creating initial populations
        //Need to change it so it is truly random and not just stupid THIS IS THE SOURCE OF MY PROBLEMS
        public List<Planet> ShufflePlanets(List<Planet> p)
        {
            List<Planet> planets = p;
            List<int> ExcludedIndexes = new List<int>();
            int planetCount = p.Count;
            Random r = new Random(Guid.NewGuid().GetHashCode());

            for(int i = 0; i <= planetCount - 1; i++)
            {
                int swappingIndex = r.Next(0, planetCount);

                if(ExcludedIndexes.Contains(swappingIndex))
                {
                    swappingIndex = r.Next(0, planetCount);
                }
                else
                {
                    ExcludedIndexes.Add(swappingIndex);
                    Planet tempPlanet = planets[swappingIndex];
                    planets[swappingIndex] = planets[i];
                    planets[i] = tempPlanet;
                }
            }

            return planets;
        }
    }
}
