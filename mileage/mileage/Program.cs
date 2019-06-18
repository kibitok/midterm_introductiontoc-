using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mileage
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double totalMiles = 0;
            double totalGallons = 0;

            while (true)
            {
                Console.Write("Enter the miles used (-1 to quit): ");
                miles = double.Parse(Console.ReadLine());
                if (miles == -1) return;
                totalMiles += miles;

                Console.Write("Enter gallons: ");
                gallons = double.Parse(Console.ReadLine());
                totalGallons += gallons;

                Console.WriteLine("MPG this tankful: {0:F6}", miles / gallons);
                Console.ReadKey();
                Console.WriteLine("Total MPG: {0:F6}", totalMiles / totalGallons);
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}

