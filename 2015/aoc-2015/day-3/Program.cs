/*
 
--- Day 3: Perfectly Spherical Houses in a Vacuum ---

Santa is delivering presents to an infinite two-dimensional grid of houses.

He begins by delivering a present to the house at his starting location, 
and then an elf at the North Pole calls him via radio and tells him where to move next. 
Moves are always exactly one house to the north (^), south (v), east (>), or west (<). 
After each move, he delivers another present to the house at his new location.

However, the elf back at the north pole has had a little too much eggnog, 
and so his directions are a little off, and Santa ends up visiting some houses more than once. 
How many houses receive at least one present?

For example:

    > delivers presents to 2 houses: one at the starting location, and one to the east.
    ^>v< delivers presents to 4 houses in a square, including twice to the house at his starting/ending location.
    ^v^v^v^v^v delivers a bunch of presents to some very lucky children at only 2 houses.

--- Part Two ---

The next year, to speed up the process, Santa creates a robot version of himself, 
Robo-Santa, to deliver presents with him.

Santa and Robo-Santa start at the same location (delivering two presents to the same starting house), 
then take turns moving based on instructions from the elf, 
who is eggnoggedly reading from the same script as the previous year.

This year, how many houses receive at least one present?

For example:

    ^v delivers presents to 3 houses, because Santa goes north, and then Robo-Santa goes south.
    ^>v< now delivers presents to 3 houses, and Santa and Robo-Santa end up back where they started.
    ^v^v^v^v^v now delivers presents to 11 houses, with Santa going one direction and Robo-Santa going the other.

 */

using System;
using System.Collections.Generic;
using System.IO;

/*
 * Completed 2020-03-06
 */
namespace day_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Santa santa = new Santa();
            Santa robotSanta = new Santa();
            Dictionary<Position, int> history = new Dictionary<Position, int> {{new Position(0, 0), 1}};

            string path = @"input.txt";
            string inputString;

            // Open file and read content
            using (StreamReader streamReader = File.OpenText(path))
            {
                inputString = streamReader.ReadToEnd();
            }

            for (var i = 0; i < inputString.Length; i++)
            {
                Position position = i % 2 == 0
                    ? santa.Move((Direction) inputString[i])
                    : robotSanta.Move((Direction) inputString[i]);

                if (!history.ContainsKey(position))
                {
                    history.Add(position, 0);
                }

                history[position]++;
            }

            Console.WriteLine("Number of houses with at least one present: {0}", history.Count);
        }
    }
}