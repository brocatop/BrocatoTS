using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BrocatoTS.Classes
{
    class GeneticAlgorithm
    {
        public GeneticAlgorithm()
        {

        }


        public DataTable Algorithm(int generations, List<Route> population)
        {
            double shortestDistanceSoFar = 0;
            Population p = new Population();
            Route route = new Route();
            List<Route> nextPopulation = new List<Route>();
            Route child = new Route();
            DataTable dt = new DataTable();
            DataColumn generationCount = new DataColumn
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            DataColumn shortestDistance = new DataColumn();

            for(int i = 0; i <= generations - 1; i++)
            {
                //I need to sort out the population
                double shortestDistanceThisGeneration = population[0].Distance;

                foreach(Route r in population)
                {
                    if(r.Distance <= shortestDistanceThisGeneration)
                    {
                        shortestDistanceThisGeneration = r.Distance;
                    }
                }

                if (shortestDistanceThisGeneration <= shortestDistanceSoFar)
                {
                    shortestDistanceSoFar = shortestDistanceThisGeneration;
                }

                dt.Rows.Add(shortestDistanceSoFar);


                int p1 = p.Selection(population.Count());
                int p2 = p.Selection(population.Count());

                while (p1 == p2)
                {
                    p2 = p.Selection(population.Count());
                }

                Route parent1 = population[p1];
                Route parent2 = population[p2];

                nextPopulation = p.InitialPopulation(parent1.Planets);

                child = p.Crossover(parent1, parent2);

                //The solution may or not be mutated, but this is where it would happen
                child = p.SwapMutation(child);

                nextPopulation.Add(child);
                population = nextPopulation;
            }

            //append the new solutions to the solution variable

            return dt;
        }

        //Calculates the fitness score of a given solution
        //Closer to zero the score is, the more efficient it is
        public double CalculateFitness(double distance)
        {
            double fitness;

            fitness = (1 / distance) * 100;

            return fitness;
        }
    }
}
