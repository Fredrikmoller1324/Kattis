using System;
using System.Collections.Generic;
using System.Linq;

namespace LineThemUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPeople = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < amountOfPeople; i++)
            {
                names.Add(Console.ReadLine());
            }

            var orderByAcending = names.OrderBy(x=>x).ToList();
            var orderByDecending = names.OrderByDescending(x=>x).ToList();

            //jämför listor med hänsyn till ordning
            if(names.SequenceEqual(orderByAcending)){
                System.Console.WriteLine("INCREASING");
            }
            else if(names.SequenceEqual(orderByDecending)){
                System.Console.WriteLine("DECREASING");
            }
            else{
                System.Console.WriteLine("NEITHER");
            }
        }
    }
}
