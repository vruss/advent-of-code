using System;
using System.IO;

/*
 * Completed 2020-03-06
 */
namespace day_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"input.txt";
            int totalPaper = 0;
            int totalRibbon = 0;

            // Open file and read content
            using (StreamReader streamReader = File.OpenText(path))
            {
                string inputString;
                while ((inputString = streamReader.ReadLine()) != null)
                {
                    string[] measurements = inputString.Split('x');
                    Box box = new Box(Convert.ToInt32(measurements[0]), Convert.ToInt32(measurements[1]),
                        Convert.ToInt32(measurements[2]));

                    totalPaper += box.getSurfaceArea();
                    totalRibbon += box.getRibbonAmount();
                }
            }
            Console.WriteLine("Total square feet of wrapping paper: {0}", totalPaper);
            Console.WriteLine("Total feet of ribbon : {0}", totalRibbon);
        }
    }
}