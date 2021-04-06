using System;
using System.Collections.Generic;

namespace KattisQstopWatch
{
    class Program
    {
        /*
         Robin just received a stopwatch from her grandfather. 
        Robin’s stopwatch has a single button. Pressing the button alternates between stopping and starting the stopwatch’s timer. 
        When the timer is on, the displayed time increases by 1 every second.

        Initially the stopwatch is stopped and the timer reads 0 seconds. 
        Given a sequence of times that the stopwatch button is pressed, determine what the stopwatch’s timer displays.
         */


        //INPUT 

        /*
         The first line of input contains a single integer N (1≤N≤1000), which is the number of times the stopwatch was pressed.

         The next N lines describe the times the stopwatch’s button was pressed in increasing order.
         Each line contains a single integer t ( 0 ≤ t ≤ 106 ), which is the time the button was pressed. No two button presses happen on the same second.
         */
        static void Main(string[] args)
        {
            int numberOfPresses = int.Parse(Console.ReadLine());

            int accumelatedTime = 0;
            int cTime = 0;
            List<int> timeStamps = new List<int>();
            
            if (numberOfPresses % 2 != 0) { Console.WriteLine("still running");}
            else
            {
                for (int i = 0; i < numberOfPresses; i++)
                {
                    timeStamps.Add(int.Parse(Console.ReadLine()));
                }

                for (int i = 0; i < timeStamps.Count; i++)
                {
                    for (int j = i+1; j < timeStamps.Count; j+=2)
                    {
                        cTime = timeStamps[j] - timeStamps[i];

                        i = j+1;

                        accumelatedTime += cTime;
                    }
                }

                Console.WriteLine(accumelatedTime);
            }  
        }
    }
}
