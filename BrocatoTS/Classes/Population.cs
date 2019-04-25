using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrocatoTS.Classes
{
    class Population
    {
        public Population()
        {

        }

        //This code originated from a sample provided by Professor Wilkins, the instructor for this course. I have modified it to work in C#
        public Route Selection(List<Route> routes)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            Route parent = new Route();
            double chance = r.NextDouble();
            int index;

            //5%
            if(chance <= .05)
            {
                index = r.Next(96, 100) - 1;
                parent = routes[index];
            }
            //20%
            else if(chance <= .25)
            {
                index = r.Next(76, 95) - 1;
                parent = routes[index];
            }
            //25%
            else if(chance <= .50)
            {
                index = r.Next(51, 75) - 1;
                parent = routes[index];
            }
            //50%
            else if(chance <= 1)
            {
                index = r.Next(1, 50) - 1;
                parent = routes[index];
            }


            return parent;
        }

        //Single point crossover in order to create new children
        public Route Crossover(Route parent1, Route parent2)
        {
            List<Planet> planetOrder = new List<Planet>();

            Random randomPoint = new Random(Guid.NewGuid().GetHashCode());
            int crossoverPoint = randomPoint.Next(0, parent1.Planets.Count);

            for(int i = 0; i <= crossoverPoint; i++)
            {
                planetOrder.Add(parent1.Planets.ElementAt(i));
            }

            for(int i = 0; i <= parent2.Planets.Count - 1; i++)
            {
                if(!planetOrder.Contains(parent2.Planets.ElementAt(i)))
                {
                    planetOrder.Add(parent2.Planets.ElementAt(i));
                }
            }

            Route child = new Route(planetOrder);
            randomPoint = new Random(Guid.NewGuid().GetHashCode());
            return child;
        }

        //Swap mutation for a solution
        public Route SwapMutation(Route solution)
        {
            Route mutatedSolution = solution;
            Random r = new Random(Guid.NewGuid().GetHashCode());

            int firstSwapPoint = r.Next(0, solution.Planets.Count());
            int secondSwapPoint = r.Next(0, solution.Planets.Count());

            while (firstSwapPoint == secondSwapPoint)
            {
                secondSwapPoint = r.Next(0, solution.Planets.Count());
            }


            Planet temp = mutatedSolution.Planets[firstSwapPoint];
            mutatedSolution.Planets[firstSwapPoint] = mutatedSolution.Planets[secondSwapPoint];
            mutatedSolution.Planets[secondSwapPoint] = temp;

            return mutatedSolution;
        }
        
        //Creates a randomized solution as a starting point
        public List<Route> InitialPopulation(List<Planet> initialPlanets)
        {
            Planet p = new Planet();
            List<Planet> planets = new List<Planet>();
            List<Route> population = new List<Route>();

            for(int i = 0; i <= 99; i++)
            {
                planets = p.ShufflePlanets(initialPlanets);
                Route r = new Route(planets);
                population.Add(r);
            }

            return population;
        }
    }
}
