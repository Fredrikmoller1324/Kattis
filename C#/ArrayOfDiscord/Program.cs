using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayOfDiscord
{
    class Program
    { /*
       * Not successful
       */
        
        static void Main(string[] args)
        {
            int amountZeusNumbers = int.Parse(Console.ReadLine());

            long[] zeusNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), long.Parse);

            long largestNumberLength = zeusNumbers[zeusNumbers.Length - 1].ToString().Length;
            int indexOfChangedNumber = 0;
            long faultyNumber = 0;

            long firstLongestNumber = 0;

            for (int i = 0; i < zeusNumbers.Length - 1; i++)
            {
                if (zeusNumbers[i].ToString().Length == largestNumberLength)
                {
                    firstLongestNumber = zeusNumbers[i];
                    indexOfChangedNumber = i;
                    break;
                }
            }

            var LengthOfAllNumsIsOne = false;
            List<long> boolCheckLength = new List<long>();

            foreach (var number in zeusNumbers)
            {
                if(number.ToString().Length == 1)
                {
                    boolCheckLength.Add(number);
                }
            }

            if(boolCheckLength.Count() == zeusNumbers.Length)
            {
                LengthOfAllNumsIsOne = true;
            }

            if (LengthOfAllNumsIsOne)
            {
                zeusNumbers[0] = 9;

                if(zeusNumbers[1] != 9)
                {
                    foreach (var number in zeusNumbers)
                    {
                        if(number == zeusNumbers[zeusNumbers.Length -1])
                        {
                            Console.Write(number);

                        }
                        else
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("impossible");
                }
            }
            else if (firstLongestNumber != 0)
            {
                var firstAsString = firstLongestNumber.ToString();

                StringBuilder sb = new StringBuilder(firstAsString);

                for (int i = 0; i < firstAsString.Length; i++)
                {
                    if (int.Parse(firstAsString[i].ToString()) < 9)
                    {
                        sb[i] = '9';
                        faultyNumber = long.Parse(sb.ToString());
                        break;
                    }
                }

                if (faultyNumber != 0 && faultyNumber > zeusNumbers[zeusNumbers.Length - 1])
                {
                    zeusNumbers[indexOfChangedNumber] = faultyNumber;

                    foreach (var number in zeusNumbers)
                    {
                        if (number == zeusNumbers[zeusNumbers.Length - 1])
                        {
                            Console.Write(number);

                        }
                        else
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
                else if (faultyNumber != 0 && faultyNumber < zeusNumbers[zeusNumbers.Length - 1])
                {
                    var lastnumberToChange = zeusNumbers[zeusNumbers.Length - 1];

                    StringBuilder builder = new StringBuilder(lastnumberToChange.ToString());

                    builder[0] = '1';

                    faultyNumber = long.Parse(builder.ToString());

                    zeusNumbers[zeusNumbers.Length - 1] = faultyNumber;

                    foreach (var number in zeusNumbers)
                    {
                        if (number == zeusNumbers[zeusNumbers.Length - 1])
                        {
                            Console.Write(number);
                        }
                        else
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
            }
            else
            {
                var grouped = zeusNumbers.GroupBy(num => num.ToString().Length).Where(gr => gr.Count() >= 2);

                var lastGroupValues = grouped.Last().ToList();

                var indexOfFirstGroupedValue = Array.IndexOf(zeusNumbers, lastGroupValues[0]);



                for (int i = 0; i < lastGroupValues[0].ToString().Length; i++)
                {
                    if (lastGroupValues[1].ToString()[i] != 9)
                    {
                        StringBuilder sBuilder = new StringBuilder(zeusNumbers[indexOfFirstGroupedValue].ToString());
                        sBuilder[i] = '9';

                        faultyNumber = long.Parse(sBuilder.ToString());

                        if (faultyNumber > lastGroupValues[1])
                        {
                            zeusNumbers[indexOfFirstGroupedValue] = faultyNumber;

                            foreach (var number in zeusNumbers)
                            {
                                if (number == zeusNumbers[zeusNumbers.Length - 1])
                                {
                                    Console.Write(number);

                                }
                                else
                                {
                                    Console.Write(number + " ");
                                }
                            }
                            break;

                        }
                        if (i == lastGroupValues[0].ToString().Length - 1)
                        {
                            Console.WriteLine("impossible");
                        }

                    }
                }
            }
        }
    }
}
