using System;
using System.IO;

namespace day_1
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

                // (PART 2) Check if santa is at the basement for the first time
                if (floor == -1)
                {
                    Console.WriteLine("Santa first entered basement at position {0}", ++i);
                    break;
                }
            }

            // Write resulting floor
            Console.WriteLine("Santa exited the apartment at floor {0}", floor);
        }
    }
}