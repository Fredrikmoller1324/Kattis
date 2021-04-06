using System;
using System.Collections.Generic;
using System.Linq;

namespace SevenWonders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double fullPoints = 0;
            double tCards = 0;
            double cCards = 0;
            double gCards = 0;

            List<double> amountOfDifferentcards = new List<double>();

            foreach (Char chars in input)
            {
                if(chars == 'T') { tCards++;}
                else if (chars == 'C') { cCards++; }
                else { gCards++; }
            }

            amountOfDifferentcards.Add(tCards);
            amountOfDifferentcards.Add(cCards);
            amountOfDifferentcards.Add(gCards);

            double additionalPoints = amountOfDifferentcards.Min() * 7;

            fullPoints = Math.Pow(tCards, 2) + Math.Pow(cCards, 2) + Math.Pow(gCards, 2) + additionalPoints;

            Console.WriteLine(fullPoints);
        }
    }
}

/*
 Seven Wonders is a card drafting game in which players build structures to earn points.
The player who ends with the most points wins. One winning strategy is to focus on building scientific structures.
There are three types of scientific structure cards: Tablet (‘T’), Compass (‘C’), and Gear (‘G’). For each type of cards,
a player earns a number of points that is equal to the squared number of that type of cards played. Additionally,
for each set of three different scientific cards, a player scores 7 points.
For example, if a player plays 3 Tablet cards, 2 Compass cards and 1 Gear card, she gets (3^2) + (2^2) + (1^2) + 7 = 21 points.

It might be tedious to calculate how many scientific points a player gets by the end of each game.
Therefore, you are here to help write a program for the calculation to save everyone’s time.

INPUT

The input has a single string with no more than 50 characters.
The string contains only letters ‘T’, ‘C’ or ‘G’, which denote the scientific cards a player has played in a Seven Wonders game.

TCGTTC = 21 => T: 3^2 + C: 2^2 + G: 1^2  + 7 = 21
CCC = 9 => C: 3^2 = 9
TTCCGG = 26 => (2^2)*3 + 7 + 7 = 26

 */
