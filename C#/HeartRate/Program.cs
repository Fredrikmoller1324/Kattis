using System;

namespace HeartRate
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                double bpm = 60 * int.Parse(input[0]) / double.Parse(input[1]);
                double heartVariance = 60 / double.Parse(input[1]);
                Console.WriteLine($"{Math.Round((bpm - heartVariance),4).ToString().Replace(',','.')} {Math.Round(bpm,4).ToString().Replace(',', '.')} {Math.Round((bpm + heartVariance),4).ToString().Replace(',', '.')}");
            }
        }
    }
}

// Don't know why it isnt accepted