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
            int chance = r.Next(0, 100);
            int index;

            if(chance <= 5)
            {
                index = r.Next(10, 12) - 1;
                parent = routes[index];
            }
            else if(chance <= 20)
            {
                index = r.Next(7, 9) - 1;
                parent = routes[index];
            }
            else if(chance <= 40)
            {
                index = r.Next(4, 6) - 1;
                parent = routes[index];
            }
            else if(chance <= 100)
            {
                index = r.Next(1, 3) - 1;
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

            return child;
        }

        //Swap mutation for a solution
        public Route SwapMutation(Route solution)
        {
            Route mutatedSolution = solution;
            Random r = new Random(Guid.NewGuid().GetHashCode());


            int firstSwapPoint = r.Next(0, solution.Planets.Count());
            int secondSwapPoint = r.Next(0, solution.Planets.Count());

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

            for(int i = 0; i <= 11; i++)
            {
                planets = p.ShufflePlanets(initialPlanets);
                Route r = new Route(planets);
                population.Add(r);
            }

            return population;
        }
    }
}
