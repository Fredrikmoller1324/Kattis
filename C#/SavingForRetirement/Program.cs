using System;

namespace SavingForRetirement
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int Adiff = 0;
            int Atot = 0;

            string[] subs = input.Split(" ");

            int Btot = (int.Parse(subs[1]) - int.Parse(subs[0])) * int.Parse(subs[2]);

            while (Atot <= Btot)
            {
                Atot += int.Parse(subs[4]);
                Adiff++;
            }

            int Aretire = Adiff + int.Parse(subs[3]);
            Console.WriteLine(Aretire);
        }
    }
}
