using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> input = File.ReadAllLines(@"C:\Users\Omari\Documents\funny coding\c#\ADVENT OF CODE\AOC\Day 3\bin\Debug").ToList();
            string fileN = "input.txt";
            List<string> input = new List<string>;
            using (StreamReader inpy = new StreamReader(fileN))
            {
                while (!inpy.EndOfStream)
                {
                    string reading = Console.ReadLine();
                    input.Add(reading);

                }
            }


            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    char currentChar = input[i][j];
                    Console.WriteLine("{0}", currentChar);
                }

            }



            Console.ReadKey();
        }
    }
}
