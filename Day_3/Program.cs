using System;
using System.IO;
using System.Linq;


namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"input.txt");
            int length = 1;
            int[] gammaRate = new int[lines[0].Length];
            int[] epsilonRate = new int[lines[0].Length];

            // the following string[]'s are for an earlier test that I want to keep as a reference. 
            // Each array will hold the values being looped through on lines 31 and 33.
            // the switch on line 55 is where the values would get stored into the corresponding arrays. 
            // string[] zero = new string[lines.Length];
            // string[] one = new string[lines.Length];
            // string[] two = new string[lines.Length];
            // string[] three = new string[lines.Length];
            // string[] four = new string[lines.Length];

            for (int indexCounter = 0; indexCounter < lines[0].Length; indexCounter++)
            {
                int scoreZero = 0;
                int scoreOne = 1;

                for (int i = 0; i < lines.Length; i++)
                {
                    String substring = lines[i].Substring(indexCounter, length); 

                    // use a switch to keep score between 1's and zero's in each indexCounter column
                    switch (substring) 
                    {
                        case "0":
                            scoreZero = scoreZero + 1;
                            break;
                        case "1":
                            scoreOne = scoreOne + 1;
                            break;
                    }

                    // store the winner in an array[lines[0].Length] for each corresponding indexCounter position array
                    if (scoreZero > scoreOne) {
                        gammaRate[indexCounter] = 0;
                        epsilonRate[indexCounter] = 1;
                    } else {
                        gammaRate[indexCounter] = 1;
                        epsilonRate[indexCounter] = 0;
                    }

                    // switch (indexCounter) this switch creates 5 arrays for each indexCounter position. Each array will match lines.Length! 
                    // {
                    //     case 0:
                    //         zero[i] = substring;
                    //         break;
                    //     case 1:
                    //         one[i] = substring;
                    //         break;
                    //     case 2:
                    //         two[i] = substring;
                    //         break;
                    //     case 3:
                    //         three[i] = substring;
                    //         break;
                    //     case 4:
                    //         four[i] = substring;
                    //         break;
                    // }
                }    
            }  

            // run a binary calculator on the final array
            int gamma = gammaRate.Aggregate(0, (a, x) => (a << 1) | (x == 0 ? 0 : 1));
                Console.WriteLine(gamma);
            int epsilon = epsilonRate.Aggregate(0, (a, x) => (a << 1) | (x == 0 ? 0 : 1));
                Console.WriteLine(epsilon);
            int powerConsumption = gamma * epsilon; 
                Console.WriteLine(powerConsumption);

            var lifeSupport = 0;
            var oxygenGenerator = 0;
            var scrubber = 0;


            // the following outputs are test cases for the comment explained on line 17.
            // Console.WriteLine(zero[0] + " | " + zero[1] + " | " + zero[2] + " | " + zero[3] + " | " + zero[4] + " | " + zero.Length);
            // Console.WriteLine(one.Length);
            // Console.WriteLine(two.Length);
            // Console.WriteLine(three.Length);
            // Console.WriteLine(four.Length);
        }
    }
}
