using System;

namespace BrocatoTS.Classes
{
    class Planets
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        string Name { get; set; }

        public Planets(int x, int y, string name)
        {
            XCoordinate = x;
            YCoordinate = y;
            Name = name;
        }

        public Planets()
        {

        }

        private Tuple<int, int> DistanceBetweenPlanets(Planets p1, Planets p2)
        {
            int xDistance = p1.XCoordinate - p2.XCoordinate;
            int yDistance = p1.YCoordinate - p2.YCoordinate;

            return Tuple.Create(xDistance, yDistance);
        }
    }
}
