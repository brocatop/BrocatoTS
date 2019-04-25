using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrocatoTS.Classes
{
    class GeneticAlgorithm
    {
        public GeneticAlgorithm()
        {

        }

        Helper h = new Helper();
        Population p = new Population();

        public DataTable Algorithm(int generations, int mutationPercent, List<Route> population)
        {
            double shortestDistanceSoFar = 0;
               
            //Initialization variables for the datatable and the rest of the method
            List<Route> nextPopulation = new List<Route>();
            Route child1;
            Route child2;
            DataTable dt = new DataTable();
            DataColumn generationCounter = new DataColumn();
            generationCounter.DataType = System.Type.GetType("System.Int32");
            DataColumn shortestDistance = new DataColumn();
            shortestDistance.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(generationCounter);
            dt.Columns.Add(shortestDistance);



            //This counter is to go through all of the generations
            for(int i = 0; i <= generations; i++)
            {
                //Establish shortestDistanceThisGeneration to 0
                double shortestDistanceThisGeneration = 0;

                //Goes through each route and records the shortest, comparing it to the best so far
                foreach(Route r in population)
                {
                    double routeDistance = h.CalculateDistance(r.Planets);

                    if (shortestDistanceThisGeneration == 0)
                    {
                        shortestDistanceThisGeneration = routeDistance;
                    }                  
                    else if(routeDistance <= shortestDistanceThisGeneration)
                    {
                        shortestDistanceThisGeneration = routeDistance;
                    }

                    if(shortestDistanceSoFar == 0)
                    {
                        shortestDistanceSoFar = routeDistance;
                    }
                    else if (shortestDistanceThisGeneration <= shortestDistanceSoFar)
                    {
                        shortestDistanceSoFar = shortestDistanceThisGeneration;
                    }                 
                }

                population = SortByFitness(population);
                dt.Rows.Add(i+1, shortestDistanceSoFar);


                for (int id = 0; id <= population.Count - 2; id = id +2)
                {
                    Route parent1 = p.Selection(population);
                    Route parent2 = p.Selection(population);

                    child1 = p.Crossover(parent1, parent2);
                    child2 = p.Crossover(parent2, parent1);
                    Console.WriteLine("crossover");

                    //The solution may or not be mutated, but this is where it would happen
                    Random r2 = new Random(Guid.NewGuid().GetHashCode());
                    int mutationChance = r2.Next(0, 100);

                    if (mutationChance <= mutationPercent)
                    {
                        child1 = p.SwapMutation(child1);
                        child2 = p.SwapMutation(child2);
                        Console.WriteLine("Mutation");
                       
                    }
                    nextPopulation.Add(child1);
                    nextPopulation.Add(child2);

                }
                population = new List<Route>(nextPopulation);
                nextPopulation.Clear();
            }
            return dt;
        }

        //Calculates the fitness score of a given solution
        public double CalculateFitness(double distance)
        {
            double fitness;

            fitness = (1 / distance) * 100;

            return fitness;
        }

        //Sorts the solutions by fitness for better selection
        public List<Route> SortByFitness(List<Route> routes)
        {
            List<Route> sortedRoutes = routes.OrderBy(d => d.Distance).ToList();
            return sortedRoutes;
            /*
            for(int i = 0; i <= routes.Count - 2; i++)
            {
                double currentFitness = CalculateFitness(routes[i].Distance);
                double nextFitness = CalculateFitness(routes[i+1].Distance);
                Route temp;

                if(currentFitness < nextFitness)
                {
                    temp = routes[i];
                    routes[i] = routes[i + 1];
                    routes[i + 1] = temp;
                }
            } 
            Console.WriteLine("Fitness has been successfully sorted");
            return routes; */
        }
    }
}
