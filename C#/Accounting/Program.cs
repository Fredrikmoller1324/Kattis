using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] peopleAndCases = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            Dictionary<int, int> peopleAndCash = new Dictionary<int, int>();

            int baseValue = 0;

            for (int i = 0; i < peopleAndCases[1]; i++)
            {
                var input = Console.ReadLine();

                if (input.Contains("SET"))
                {
                    var values = input.Split(" ");
                    int person = int.Parse(values[1]);
                    int money = int.Parse(values[2]);

                    peopleAndCash[person] = money;
                }
                else if (input.Contains("RESTART"))
                {
                    var values = input.Split(" ");
                    peopleAndCash.Clear();
                    baseValue = int.Parse(values[1]);
                }
                else if (input.Contains("PRINT"))
                {
                    var values = input.Split(" ");

                    var cashValue = 0;
                    var peopleexist = peopleAndCash.TryGetValue(int.Parse(values[1]), out cashValue);

                    if (peopleexist)
                    {
                        Console.WriteLine(cashValue);
                    }
                    else
                    {
                        Console.WriteLine(baseValue);
                    }
                }
            }
        }
    }
}
