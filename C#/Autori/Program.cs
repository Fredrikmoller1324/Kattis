using System;
using System.Collections.Generic;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string indexOfSubstring = "-";

            List<int> indicesOfSubstrings = new List<int>();
            int index = 0;

            //om en index ej kan finnas returneras -1
            while((index = input.IndexOf(indexOfSubstring,index)) != -1)
            {
                indicesOfSubstrings.Add(index + 1);
                index++;
            }

            string lastLetters = $"{input[0]}";
            foreach (var number in indicesOfSubstrings)
            {
                lastLetters += input[number];
            }

            Console.WriteLine(lastLetters);
        }
    }
}
