using System;
using System.IO;

namespace aoc_2015_day_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"input.txt";
            string inputString;
            int floor = 0;

            // Open file and read content
            using (StreamReader streamReader = File.OpenText(path))
            {
                inputString = streamReader.ReadToEnd();
            }

            // Traverse the apartment building
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    floor++;
                }
                else if (inputString[i] == ')')
                {
                    floor--;
                }
            }

            // Write resulting floor
            Console.WriteLine(floor);
        }
    }
}