﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace AOC
{
    class P1
    {   
        // static public 
        static void Main(string[] args)
        {
            // who knows if i'm smart enough fro this lol.
            // Day 1 P1
            //Class1.whatsUp();

            Console.ReadKey();
            string fName = "readingFileTest.txt";
            int lineNumber = 0;
            List<int> counting = new List<int>();
            List<int> totalNumbers = new List<int>();
            using (StreamReader readingItUp = new StreamReader(fName))
            {
                while (!readingItUp.EndOfStream)
                {
                    string line = readingItUp.ReadLine();
                    Console.WriteLine("{0}", line);
                    counting.Clear();
                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];
                        if (char.IsDigit(currentChar) == true)
                        {
                            // Console.WriteLine($"{currentChar}");
                            counting.Add(int.Parse(currentChar.ToString()));
                        }
                        //else
                        //{
                        //    Console.Write("N");
                        //}
                    }
                    if (counting.Count > 2)
                    {
                        counting.RemoveRange(1, counting.Count - 2);
                        quickAppend(counting,totalNumbers);
                    }
                    else if (counting.Count == 1)
                    {
                        quickAppend(counting,totalNumbers);
                    }
                    else if (counting.Count == 0)
                    {
                        Console.WriteLine("No numbers were found on this line.");
                    }
                    else
                    {
                        quickAppend(counting, totalNumbers);
                    }
                    for (int i = 0; i < counting.Count; i++)
                    {
                        Console.WriteLine("{0}", counting[i]);
                    }
                    lineNumber++;
                    Console.WriteLine("LF {0}", lineNumber);
                }
            }

            int sum = 0;
            for (int i = 0; i < totalNumbers.Count; i++)
            {
                sum += totalNumbers[i];
            }
            Console.WriteLine("the sum: {0}", sum);
            //for (int i = 0; i < totalNumbers.Count; i++) // printing out total numbers.
            //{
            //    Console.Write("{0} ", totalNumbers[i]);
            //}
            Console.ReadKey(); Console.ReadKey();

        }
        static public void quickAppend(List<int> counting,List<int> totalNumbers)
        {
            for (int i = 0; i < counting.Count; i++)
            {
                totalNumbers.Add(counting[i]);
            }
        }
    }
}
