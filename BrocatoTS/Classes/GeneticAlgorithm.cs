using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BrocatoTS.Classes
{
    class GeneticAlgorithm
    {
        public GeneticAlgorithm()
        {

        }

        Helper h = new Helper();

        public DataTable Algorithm(int generations, int mutationPercent, List<Route> population)
        {
            double shortestDistanceSoFar = 0;
            Helper h = new Helper();
            Population p = new Population();
            List<Route> nextPopulation = new List<Route>();
            Route child;
            DataTable dt = new DataTable();
            DataColumn generationCounter = new DataColumn();
            generationCounter.DataType = System.Type.GetType("System.Int32");
            DataColumn shortestDistance = new DataColumn();
            shortestDistance.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(generationCounter);
            dt.Columns.Add(shortestDistance);

            for(int i = 0; i <= generations; i++)
            {
                double shortestDistanceThisGeneration = 0;

                foreach(Route r in population)
                {
                    double routeDistance = h.CalculateDistance(r.Planets);
                    if(shortestDistanceThisGeneration == 0)
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

                foreach(Route route in population.ToList())
                {
                    Route parent1 = p.Selection(population);
                    Route parent2 = p.Selection(population);

                    while(parent1 == parent2)
                    {
                        parent2 = p.Selection(population);
                    }

                    child = p.Crossover(parent1, parent2);

                    //The solution may or not be mutated, but this is where it would happen
                    Random r = new Random(Guid.NewGuid().GetHashCode());
                    int mutationChance = r.Next(0, 100);

                    if (mutationChance <= mutationPercent)
                    {
                        child = p.SwapMutation(child);
                    }
                    nextPopulation.Add(child);

                    //MessageBox.Show("child has been added to the next population");
                }
                
                population = nextPopulation;
            }

            MessageBox.Show("The datatable has been created");
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
            /*
            for(int i = 0; i <= routes.Count - 1; i++)
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
            } */

            Console.WriteLine("Fitness has been successfully sorted");
            return routes;

        }
    }
}
