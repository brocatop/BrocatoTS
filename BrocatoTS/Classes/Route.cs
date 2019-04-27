using System.Collections.Generic;

namespace BrocatoTS.Classes
{
    class Route
    {
        //Properties for the a planets lsit in a route and for the distance
        public List<Planet> Planets { get; set; }
        public double Distance { get; set; }

        //Constructor
        public Route(List<Planet> planets)
        {
            Planets = planets;
        }

        //Default constructor
        public Route()
        {

        }
    }
}
