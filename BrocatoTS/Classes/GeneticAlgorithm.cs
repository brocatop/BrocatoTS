using System.Data;

namespace BrocatoTS.Classes
{
    class GeneticAlgorithm
    {
        public GeneticAlgorithm()
        {

        }


        public DataTable Algorithm(int generations)
        {
            double shortestDistanceSoFar = 0;
            double shortestDistanceThisGeneration = 0;

            DataTable dt = new DataTable();
            DataColumn generationCount = new DataColumn
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            DataColumn shortestDistance = new DataColumn();

            //Variable to hold solutions


            for(int i = 0; i <= generations - 1; i++)
            {
                //Take in all of the solutions for the initial generation

                if(shortestDistanceThisGeneration <= shortestDistanceSoFar)
                {
                    shortestDistanceSoFar = shortestDistanceThisGeneration;
                }

                //Add the best solution up to this point into the datatable
                DataRow dr = ;
                dt.Rows.Add(dr);

                //I think here is where I will implement selection, crossover, and mutation 
                //for the next batch of solutiuons
                
                //append the new solutions to the solution variable
            }

            return dt;
        }

        public double CalculateFitness(double distance)
        {
            double fitness;

            fitness = (1 / distance) * 100;

            return fitness;
        }
    }
}
