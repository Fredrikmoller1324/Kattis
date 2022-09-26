using System;
using System.Collections.Generic;
using System.Linq;

namespace Ants
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                int minTime = 0;
                int[] maxTime;

                string[] plankLengthAndAmountAnts = Console.ReadLine().Split(" ");

                int plankLength = int.Parse(plankLengthAndAmountAnts[0]);

                int totAmountAnts = int.Parse(plankLengthAndAmountAnts[1]);

                List<int> antsStartPositions = new List<int>();

                for (int z = 0; z < totAmountAnts; z++)
                {
                    if (antsStartPositions.Count() < totAmountAnts)
                    {
                        var ants = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                        for (int q = 0; q < ants.Length; q++)
                        {
                            antsStartPositions.Add(ants[q]);
                        }
                    }
                    else if(antsStartPositions.Count() >= totAmountAnts)
                    {
                        break;
                    }
                }

                for (int y = 0; y < antsStartPositions.Count(); y++)
                {
                    minTime = Math.Max(Math.Min(antsStartPositions[y], plankLength - antsStartPositions[y]), minTime);
                }

                maxTime = new int[] { antsStartPositions.Max(), plankLength - antsStartPositions.Min() };

                Console.WriteLine(minTime + " " + maxTime.Max());
            }
        }
    }
}
