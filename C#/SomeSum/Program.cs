using System;

namespace SomeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                        Console.WriteLine("Either");
                        break;
                    case 2:
                    case 6:
                    case 10:
                        Console.WriteLine("Odd");
                        break;
                    case 4:
                    case 8:
                        Console.WriteLine("Even");
                        break;
                }
        }
    }
}
