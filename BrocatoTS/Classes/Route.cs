using System.Collections.Generic;

namespace BrocatoTS.Classes
{
    class Route
    {
        public double Distance { get; set; }
        public List<Planet> Planets { get; set; }

        Helper h = new Helper();

        public Route(List<Planet> planets)
        {
            Distance = h.CalculateDistance(planets);
            Planets = planets;
        }

        public Route()
        {

        }

    }
}
