using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 1;
            int maxValue = 1000;

            while (true)
            {
                var guess = (minValue + maxValue) / 2;

                Console.WriteLine(guess);
                
                var answer = Console.ReadLine();

                if(answer == "correct")
                {
                    break;
                }
                else if(answer == "lower")
                {
                    maxValue = guess - 1;
                }
                else if(answer == "higher")
                {
                    minValue = guess + 1;
                }
            }
        }
    }
}
