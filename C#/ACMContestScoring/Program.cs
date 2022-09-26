using System;
using System.Collections.Generic;
using System.Linq;

namespace ACMContestScoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeScore = 0;
            int amountSolvedProblems = 0;
            Dictionary<string, int> failedSubmissions = new Dictionary<string, int>();

            while (true)
            {
                string[] submissionEntry = Console.ReadLine().Split(" ");
                if (submissionEntry[0].Contains("-1"))
                {
                    break;
                }

                if(submissionEntry[2] == "wrong")
                {
                    if (failedSubmissions.ContainsKey(submissionEntry[1]))
                    {
                        failedSubmissions[submissionEntry[1]] = failedSubmissions[submissionEntry[1]] + 1;
                    }
                    else
                    {
                        failedSubmissions.Add(submissionEntry[1], 1);
                    }
                    continue;
                }

                amountSolvedProblems++;
                timeScore += int.Parse(submissionEntry[0]);
                if (failedSubmissions.ContainsKey(submissionEntry[1]))
                {
                    timeScore += failedSubmissions[submissionEntry[1]] * 20;
                }
            }

            Console.WriteLine($"{amountSolvedProblems} {timeScore}");
        }
    }
}
