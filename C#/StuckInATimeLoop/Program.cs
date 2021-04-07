using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < input + 1; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
        }
    }
}
