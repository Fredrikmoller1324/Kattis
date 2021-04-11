using System;
using System.Collections.Generic;

namespace Avion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                codes[i] = Console.ReadLine();
            }

            string output = "";
            int index = 1;
            foreach (var code in codes)
            {
                if (code.Contains("FBI"))
                {
                    output += index + " ";
                }

                index++;
            }

            if(output == "")
            {
                output = "HE GOT AWAY!";
            }

            Console.WriteLine(output);
        }
    }
}
