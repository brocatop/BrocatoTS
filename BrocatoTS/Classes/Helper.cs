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


        public void GeneratePlanets(int numberOfPlanets)
        {
            List<Planets> planets = new List<Planets>();

            Random r = new Random();

            //for i <= number of planets the user inputs
            for (int i = 0; i <= numberOfPlanets; i++)
            {
                int x = r.Next(0, 500);
                int y = r.Next(0, 500);
                Planets p = new Planets(x, y, "Planets" + i+1.ToString());
                if (PlanetChecker(p, planets) == false)
                {
                    //I will need to improve this later
                    p.XCoordinate = p.XCoordinate + 1;
                }
                planets.Add(p);
            }
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
    }
}
