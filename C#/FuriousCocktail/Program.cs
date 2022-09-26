using System;
using System.Collections.Generic;
using System.Linq;

namespace FuriousCocktail
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] potsAndApplyTime = Console.ReadLine().Split(" ");

            int totAmountPots = int.Parse(potsAndApplyTime[0]);
            int applyTime = int.Parse(potsAndApplyTime[1]);

            Dictionary<int, int> potsWithDurationTime = new Dictionary<int, int>();

            for (int i = 0; i < totAmountPots; i++)
            {
                int durationTime = int.Parse(Console.ReadLine());

                potsWithDurationTime.Add(i, durationTime);
            }

            if (potsWithDurationTime.Values.Max() - (applyTime * (totAmountPots - 1)) > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        } 
    }
}
