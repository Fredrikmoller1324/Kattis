using System;
using System.Collections.Generic;
using System.Linq;

namespace Akcija
{
    public static class Extensions
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] arr, int size)
        {
            for (var i = 0; i < arr.Length / size + 1; i++)
            {
                yield return arr.Skip(i * size).Take(size);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            int[] booksPrices = new int[numberOfBooks];

            for (int i = 0; i < numberOfBooks; i++)
            {
                int price = int.Parse(Console.ReadLine());

                booksPrices[i] = price;
            }

            var orderedListOfPrices = booksPrices.OrderByDescending(p => p).ToArray();

            var groups = orderedListOfPrices.Split(3);

            int minimumPrice = 0;

            foreach (var group in groups)
            {
                if(group.Count() == 3)
                {
                    minimumPrice += group.ElementAt(0) + group.ElementAt(1); 
                }
                else
                {
                    minimumPrice += group.Sum();
                }
            }

            Console.WriteLine(minimumPrice);
        }
    }
}
