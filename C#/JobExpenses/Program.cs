using System;
using System.Collections.Generic;

namespace JobExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int recordAmount = int.Parse(Console.ReadLine());
            int totalExpenses = 0;

            string input = Console.ReadLine();

            string[] incomeAndExpenses = input.Split(" ");

            List<string> allExpenses = new List<string>();


            foreach (var incExp in incomeAndExpenses)
            {
                if (incExp.Contains('-'))
                {
                    allExpenses.Add(incExp);
                }
            }
                
            foreach (var expens in allExpenses)
            {
                totalExpenses += int.Parse(expens);
            }

            Console.WriteLine(Math.Abs(totalExpenses));
        }
    }
}
