using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrocatoTS.Classes
{
    class Population
    {
        double MutationPercent = 50;

        //This code originated from a sample provided by Professor Wilkins, the instructor for this course. I have modified the code.
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
        public List<Planets> Crossover(List<Planets> parent1, List<Planets> parent2)
        {
            List<Planets> child = new List<Planets>();

            Random randomPoint = new Random();
            int crossoverPoint = randomPoint.Next(0, parent1.Count);

            for(int i = 0; i <= crossoverPoint; i++)
            {
                child.Add(parent1[i]);
            }

            for(int i = crossoverPoint; i <= parent2.Count; i++)
            {
                child.Add(parent2[i]);
            }

            return child;
        }

        //Swap mutation for a solution
        public List<Planets> SwapMutation(List<Planets> solution)
        {
            List<Planets> mutatedSolution = solution;
            Random r = new Random();
            int mutationChance = r.Next(0, 100);

            if(mutationChance <= MutationPercent)
            {
                int firstSwapPoint = r.Next(0, solution.Count());
                int secondSwapPoint = r.Next(0, solution.Count());

                Planets temp = mutatedSolution[firstSwapPoint];
                mutatedSolution[firstSwapPoint] = mutatedSolution[secondSwapPoint];
                mutatedSolution[secondSwapPoint] = temp;

                return mutatedSolution;
            }

            return mutatedSolution;
        }
    }
}
