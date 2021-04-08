using System;
using System.Collections.Generic;

namespace CD
{
    class Program
    {
        //Hashset tillåter inga duplikat
        static void Main(string[] args)
        {
            while (true)
            {
                string[] cdLists = Console.ReadLine().Split(" ");

                if (int.Parse(cdLists[0]) == 0 && int.Parse(cdLists[1]) == 0) { break; }

                int total = int.Parse(cdLists[0]) + int.Parse(cdLists[1]);

                HashSet<string> cds = new HashSet<string>();

                for (int i = 0; i < total; i++)
                {
                    cds.Add(Console.ReadLine());
                }

                Console.WriteLine(total - cds.Count);
            }

        }
    }
}
