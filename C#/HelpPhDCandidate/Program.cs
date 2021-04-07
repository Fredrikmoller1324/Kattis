using System;
using System.Collections.Generic;

namespace HelpPhDCandidate
{
    class Program
    {
        static void Main(string[] args)
        {

            int cases = int.Parse(Console.ReadLine());
            List<string> inputs = new List<string>();

            for (int i = 0; i < cases; i++)
            {
                string input = Console.ReadLine();
                inputs.Add(input);
            }

            foreach (var input in inputs)
            {

                if (char.IsDigit(input[0]))
                {
                    string[] fixedString = input.Split('+');
                    Console.WriteLine(int.Parse(fixedString[0].ToString()) + int.Parse(fixedString[1].ToString()));
                }
                else
                {
                    Console.WriteLine("skipped");
                }
            }
        }
    }
}
