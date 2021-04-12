using System;
using System.Collections.Generic;

namespace EncodedMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int b = 0; b < cases; b++)
            {
                string input = Console.ReadLine();

                int numberofColumns = int.Parse(Math.Sqrt(input.Length).ToString());

                List<string> reversedColumns = new List<string>();

                for (int i = 0; i < input.Length; i = i + numberofColumns)
                {
                    string columnWord = "";
                    string reverscolumnWord = "";
                    for (int y = 0; y < numberofColumns; y++)
                    {
                        int index = i + y;
                        columnWord += input[index];
                    }
                    for (int j = columnWord.Length - 1; j >= 0; j--)
                    {
                        reverscolumnWord += columnWord[j];
                    }

                    reversedColumns.Add(reverscolumnWord);
                }

                string decode = "";

                for (int i = 0; i < numberofColumns; i++)
                {
                    foreach (var word in reversedColumns)
                    {
                        decode += word[i];
                    }
                }
                Console.WriteLine(decode);
            }
        }
    }
}
