using System;
using System.IO;
//using System.Collections.Generic;

namespace Day_2
{
    class Program
    {
   static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"input.txt");
            int horizontal = 0;
            int depth = 0;
            int aim = 0;
            // List<String> direction = new List<String>();
            // List<int> value = new List<int>();
            // int i = 0;



            foreach (var l in lines) {
                string[] inputs = l.Split(' ');
                // direction.Add(inputs[0]);
                // value.Add(int.Parse(inputs[1]));
                // i++;

                switch (inputs[0])
                {
                    case "forward":
                        horizontal = horizontal + Int32.Parse(inputs[1]);
                        depth = depth + aim * Int32.Parse(inputs[1]);
                        break;
                    case "up":
                        //depth = depth - Int32.Parse(inputs[1]);
                        aim = aim - Int32.Parse(inputs[1]);
                        break;
                    case "down":
                        //depth = depth + Int32.Parse(inputs[1]);
                        aim = aim + Int32.Parse(inputs[1]);
                        break;
                }
            }
            // Console.WriteLine(direction[4]);
            // Console.WriteLine(value[4]);
            // Console.WriteLine("Direction: " + direction.Count + " Value: " + value.Count);
            Console.WriteLine(horizontal * depth);

            
        }
    }
}
