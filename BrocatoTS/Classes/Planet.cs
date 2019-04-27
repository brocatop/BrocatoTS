using System;
using System.Collections.Generic;

namespace BrocatoTS.Classes
{
    class Planet
    {
        //Properties for a planet, including dimensions on the grid and their name
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int ZCoordinate { get; set; }
        public string Name { get; set; }

        //Constructor for a planet
        public Planet(int x, int y, int z, string name)
        {
            XCoordinate = x;
            YCoordinate = y;
            ZCoordinate = z;
            Name = name;
        }
    }
}
