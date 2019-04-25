using System.Collections.Generic;

namespace BrocatoTS.Classes
{
    class Route
    {
        public List<Planet> Planets { get; set; }
        public double Distance { get; set; }


        Helper h = new Helper();

        public Route(List<Planet> planets)
        {
            Planets = planets;
            //Distance = h.CalculateDistance(planets);
        }

        public Route()
        {

        }
    }
}
