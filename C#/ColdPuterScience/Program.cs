using System;
using System.Linq;

namespace ColdPuterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAmountCollectedTemps = int.Parse(Console.ReadLine());

            int amountTempsBelowZero = Console.ReadLine().Split(" ").Where(temp => temp.Contains("-")).Count();

            Console.WriteLine(amountTempsBelowZero);
        }
    }
}
