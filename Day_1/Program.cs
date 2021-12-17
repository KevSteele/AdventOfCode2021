using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sum1 = 0;
            int sum2 = 0;
            string[] lines =  System.IO.File.ReadAllLines(@"input.txt");
            int[] linesInt = Array.ConvertAll(lines, int.Parse);
             
            for (int i = 0; linesInt.Length - 2 > i; i++) 
            {   
                if (sum1 == 0) {
                    sum1 = linesInt[i] + linesInt[i+1] + linesInt[i+2];
                    sum2 = linesInt[i+1] + linesInt[i+2] + linesInt[i+3];
                } else {
                    sum2 = linesInt[i] + linesInt[i+1] + linesInt[i+2];   
                }
                if (sum1 < sum2) {
                    counter++;
                }
                sum1 = sum2;
            }
            System.Console.WriteLine("There were {0} lines greater than the one before it.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
            
        }
    }
}
