using System;
using System.Collections.Generic;

namespace KattisQNastyHacks
{
    class Program
    {
        /*
        You are the CEO of Nasty Hacks Inc., a company that creates small pieces of malicious software which teenagers may use to fool their friends.
        The company has just finished their first product and it is time to sell it. You want to make as much money as possible and consider advertising
        in order to increase sales. You get an analyst to predict the expected revenue, both with and without advertising.You now want to make a decision
        as to whether you should advertise or not, given the expected revenues.
        
        
        INPUT

        The input consists of n cases, and the first line consists of one positive integer giving n.
        The next n lines each contain 3 integers, r, e and c.The first, r, is the expected revenue if you do not advertise,
        the second, e, is the expected revenue if you do advertise, and the third, c, is the cost of advertising.
        You can assume that the input will follow these restrictions: 1 ≤ n ≤ 100, −106 ≤ r, e ≤ 106 and 0 ≤ c ≤ 106.

        Sample

        3
        0 100 70
        100 130 30
        -100 -70 40

        ----------------------------------

        advertise
        does not matter
        do not advertise

        */
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            List<int[]> chosenCase = new List<int[]>();


            for (int i = 0; i < cases; i++)
            {
                string[] lines = Console.ReadLine().Split(' ');

                chosenCase.Add(Array.ConvertAll(lines, int.Parse));
            }

            foreach (var caseChoice in chosenCase)
            {
                int r = caseChoice[0];
                int e = caseChoice[1];
                int c = caseChoice[2];

                if (r > e - c)
                {
                    Console.WriteLine("do not advertise");
                }
                else if (r == e - c)
                {
                    Console.WriteLine("does not matter");
                }
                else
                {
                    Console.WriteLine("advertise");
                }
            }


        }
    }
}
