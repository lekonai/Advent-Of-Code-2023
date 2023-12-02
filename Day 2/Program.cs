using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Day_2
{
    class Program
    {
        // constants
        const int maxR = 12;
        const int maxB = 14;
        const int maxG = 13;
        // learning what a dictionary is cause i hate this
        static int sum;
        static void Main(string[] args)
        {
            // string fileN = "input.txt";
            
            //int cBlue;
            //int cGreen;
            //int cRed;
            // sum of all the IDs.
            

            //using (StreamReader reading = new StreamReader(fileN))
            //{
            //    while (!reading.EndOfStream)
            //    {
            //        string lineRN = Console.ReadLine();

            //    }
            //}
            // not gonna use this method anymore :)
            // thanks for this one wik
            List<string> allTheGames = File.ReadAllLines("C:/Users/Omari/Documents/funny coding/c#/ADVENT OF CODE/AOC/Day 2/bin/Debug/input.txt").ToList(); // turning all those lines into one list.

            foreach (var game in allTheGames)
            {
                int semiCI = game.IndexOf(":");
                string ID = game.Substring(5, semiCI- 5);
                string gameInfo = game.Substring(semiCI + 2);
                Console.WriteLine("ID: {0}",ID);
                Console.WriteLine("Game info: {0}", gameInfo);
                Dictionary<string, int> counting = new Dictionary<string, int>
                {
                    {"red", 0 },
                    {"blue", 0 },
                    {"green", 0 }
                };
                List<string> cubeSubsets = gameInfo.Split("; ").ToList();
                foreach (var cubeSubset in cubeSubsets)
                {
                    // Get the cube sets and loop over them, "12 red" is a set
                    List<string> cubeSets = cubeSubset.Split(", ").ToList();
                    foreach (var set in cubeSets)
                    {
                        // Retrieve the colour of the cubes, and the amount of cubes in the set
                        string colour = set.Split(" ")[1];
                        int amountOfCubesInSet = int.Parse(set.Split(" ")[0]);

                        // if the colour is valid, set the amount of cubes in the set
                        if (counting.ContainsKey(colour) && amountOfCubesInSet > counting[colour])
                        {
                            counting[colour] = amountOfCubesInSet;
                        }
                    }
                }
                if (counting["red"] <= 12 && counting["green"] <= 13 && counting["blue"] <= 14)
                {
                    sum += int.Parse(ID);
                }
            }

        }
    }
}
