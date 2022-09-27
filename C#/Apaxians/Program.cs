using System;
using System.Text;

namespace Apaxians
{
    class Program
    {
        static void Main(string[] args)
        {
            string apaxianName = Console.ReadLine();

            for (int i = 0; i < apaxianName.Length - 1; i++)
            {
                if(apaxianName[i] == apaxianName[i + 1])
                {
                    apaxianName = apaxianName.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(apaxianName);
        }
    }
}
