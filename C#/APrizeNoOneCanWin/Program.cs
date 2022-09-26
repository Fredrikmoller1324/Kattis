using System;

namespace APrizeNoOneCanWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] itemsAndPrizeCost = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            int numberOfItems = itemsAndPrizeCost[0];
            int minimumPrizeCost = itemsAndPrizeCost[1];

            int[] itemsIndividualCost = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(itemsIndividualCost);

            int numberOfCheatItems = 1;

            for (int i = 0; i < numberOfItems - 1; i++)
            {
                if (itemsIndividualCost[i] + itemsIndividualCost[i + 1] <= minimumPrizeCost)
                {
                    numberOfCheatItems++;
                }
            }
                
            Console.WriteLine(numberOfCheatItems);
        }
    }
}
