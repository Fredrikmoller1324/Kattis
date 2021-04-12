using System;
using System.Linq;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                int amountStoresVisited = int.Parse(Console.ReadLine()); // onödig men krävs för att få rätt input (variabel används ej)
                string[] storeAdresses = Console.ReadLine().Split(' ');

                int[] storeAdressAsInt = storeAdresses.Select(adress => int.Parse(adress)).ToArray();

                Console.WriteLine((storeAdressAsInt.Max() - storeAdressAsInt.Min()) * 2 );

            }
        }
    }
}
