using System;

namespace AboveAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int numberOfStudents = int.Parse(input[0]);

                double classMaxPoints = 0;
                for (int y = 1; y < numberOfStudents + 1; y++)
                {
                    classMaxPoints += double.Parse(input[y]);
                }

                double avragePoints = Math.Round((classMaxPoints / numberOfStudents),3);

                double aboveAvrageStudents = 0;

                for (int j = 1; j < numberOfStudents + 1; j++)
                {
                    if(int.Parse(input[j]) > avragePoints)
                    {
                        aboveAvrageStudents++;
                    }
                }

                Console.WriteLine($"{Math.Round(((aboveAvrageStudents / numberOfStudents) * 100 ),3).ToString("N3").Replace(',', '.')}%");
            }
        }
    }
}
