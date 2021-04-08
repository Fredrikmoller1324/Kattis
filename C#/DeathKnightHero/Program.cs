using System;

namespace DeathKnightHero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBattles = int.Parse(Console.ReadLine());

            int wonBattles = 0;

            for (int i = 0; i < numberOfBattles; i++)
            {
                string battle = Console.ReadLine();
                
                if (!battle.Contains("CD"))
                {
                    wonBattles++;
                }
            }

            Console.WriteLine(wonBattles);
        }
    }
}
