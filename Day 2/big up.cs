using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_2
{
    internal class big_up
    {
        public static void main2()
        {
            List<string> input = File.ReadAllLines("C:/Users/Omari/Documents/funny coding/c#/ADVENT OF CODE/AOC/Day 2/bin/Debug/input.txt").ToList();
            (int r, int g, int b) bag = new(12, 13, 14);

            int sumIDPossible = 0;
            int sumMinPowerSets = 0;

            foreach (var line in input.Split("\r\n"))
            {
                var tokens = line.Split(new[] { "Game ", ": " }, StringSplitOptions.RemoveEmptyEntries);
                var possible = true;
                Dictionary<string, int> minimumSet = new(){
        {"red",0},
        {"green",0},
        {"blue",0}
    };
                foreach (var round in tokens[1].Split("; "))
                {
                    var colors = round.Split(new[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < colors.Length; i += 2)
                    {
                        var colorName = colors[i + 1];
                        int comparingColor = colorName switch
                        {
                            "red" => bag.r,
                            "green" => bag.g,
                            "blue" => bag.b,
                            _ => 0
                        };
                        var color = int.Parse(colors[i]);
                        minimumSet[colorName] = Math.Max(minimumSet[colorName], color);
                        if (color > comparingColor)
                        {
                            possible = false;
                        }
                    }
                }
                if (possible)
                {
                    sumIDPossible += int.Parse(tokens[0]);
                }
                sumMinPowerSets += (minimumSet["red"] * minimumSet["green"] * minimumSet["blue"]);
            }

            Console.WriteLine(sumIDPossible);
            Console.WriteLine(sumMinPowerSets);
        }
    }
}
