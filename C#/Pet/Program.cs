using System;
using System.Collections.Generic;
using System.Linq;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allFullPoints = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                string[] contestantPoints = Console.ReadLine().Split(' ');

                List<int> contestantPointsInts = contestantPoints.Select(s => int.Parse(s)).ToList();

                allFullPoints.Add(contestantPointsInts.Sum());
            }

            int contenderWinner = allFullPoints.IndexOf(allFullPoints.Max());

            Console.WriteLine($"{contenderWinner} {allFullPoints.Max()}");
        }
    }
}
