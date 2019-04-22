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
        public int Selection(int population)
        {
            int workingValue;
            Random r = new Random();

            workingValue = r.Next() % (population * 15);

            if(workingValue < (population * 8))
            {
                workingValue = workingValue % (population / 4);
                return workingValue;
            }
            else if(workingValue < (population * 12))
            {
                workingValue = (workingValue % (population / 4)) + (population / 4);
                return workingValue;
            }
            else if(workingValue < (population * 14))
            {
                workingValue = (workingValue % (population / 4)) + ((population / 4) * 2);
                return workingValue;
            }
            else
            {
                workingValue = (workingValue % (population / 4)) + ((population / 4) * 3);
                return workingValue;
            }
        }

        //Single point crossover in order to create new children
        public Route Crossover(Route parent1, Route parent2)
        {
            List<Planet> planetOrder = new List<Planet>();

            Random randomPoint = new Random();
            int crossoverPoint = randomPoint.Next(0, parent1.Planets.Count);

            for(int i = 0; i <= crossoverPoint; i++)
            {
                planetOrder.Add(parent1.Planets.ElementAt(i));
            }

            for(int i = crossoverPoint; i <= parent2.Planets.Count - 1; i++)
            {
                planetOrder.Add(parent2.Planets.ElementAt(i));
            }

            Route child = new Route(planetOrder);

            return child;
        }

        //Swap mutation for a solution
        public Route SwapMutation(Route solution, int mutationPercent)
        {
            Route mutatedSolution = solution;
            Random r = new Random();
            int mutationChance = r.Next(0, 100);

            if(mutationChance <= mutationPercent)
            {
                int firstSwapPoint = r.Next(0, solution.Planets.Count());
                int secondSwapPoint = r.Next(0, solution.Planets.Count());

                Planet temp = mutatedSolution.Planets[firstSwapPoint];
                mutatedSolution.Planets[firstSwapPoint] = mutatedSolution.Planets[secondSwapPoint];
                mutatedSolution.Planets[secondSwapPoint] = temp;

                return mutatedSolution;
            }

            return mutatedSolution;
        }
        
        //Creates a randomized solution as a starting point
        public List<Route> InitialPopulation(List<Planet> initialPlanets)
        {
            Planet p = new Planet();
            List<Planet> planets = new List<Planet>();
            List<Route> population = new List<Route>();

            for(int i = 0; i <= 9; i++)
            {
                planets = p.ShufflePlanets(initialPlanets);
                Route r = new Route(planets);
                population.Add(r);
            }

            return population;
        }
    }
}
