using System;
using System.Linq;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] inputIntInOrder = input.Select(number => int.Parse(number)).OrderBy(x => x).ToArray();

            string order = Console.ReadLine();

            switch (order)
            {
                case "ABC":
                    Console.WriteLine($"{inputIntInOrder[0]} {inputIntInOrder[1]} {inputIntInOrder[2]}");
                    break;
                case "ACB":
                    Console.WriteLine($"{inputIntInOrder[0]} {inputIntInOrder[2]} {inputIntInOrder[1]}");
                    break;
                case "BAC":
                    Console.WriteLine($"{inputIntInOrder[1]} {inputIntInOrder[0]} {inputIntInOrder[2]}");
                    break;
                case "BCA":
                    Console.WriteLine($"{inputIntInOrder[1]} {inputIntInOrder[2]} {inputIntInOrder[0]}");
                    break;
                case "CAB":
                    Console.WriteLine($"{inputIntInOrder[2]} {inputIntInOrder[0]} {inputIntInOrder[1]}");
                    break;
                case "CBA":
                    Console.WriteLine($"{inputIntInOrder[2]} {inputIntInOrder[1]} {inputIntInOrder[0]}");
                    break;
            }
        }
    }
}
