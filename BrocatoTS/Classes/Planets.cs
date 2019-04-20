using System;
using System.Collections.Generic;

namespace BrocatoTS.Classes
{
    class Planets
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }

        public Planets(int x, int y, string name)
        {
            XCoordinate = x;
            YCoordinate = y;
            Name = name;
        }

        public Planets()
        {

        }

        //Shuffles the list of planets into a random order, to be used for creating initial populations
        //Need to change it so it is truly random and not just stupid
        public List<Planets> ShufflePlanets(List<Planets> p)
        {
            List<Planets> planets = new List<Planets>();
            var ExcludedIndexes = new HashSet<int>();
            int planetCount = p.Count;
            Random r = new Random();

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
                    Planets tempPlanet = p[swappingIndex];
                    p[swappingIndex] = p[i];
                    p[i] = tempPlanet;
                }
            }

            return planets;
        }
    }
}
