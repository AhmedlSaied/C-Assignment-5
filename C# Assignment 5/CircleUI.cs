using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class CircleUI
    {
        public void Run()
        {
            Console.WriteLine("\n--- Circle Calculator ---");

            while (true)
            {
                Console.Write("Enter circle radius: ");
                if (double.TryParse(Console.ReadLine(), out double radius) && radius >= 0)
                {
                    GeometryCalculator geoCalc = new GeometryCalculator();

                    geoCalc.CalculateCircle(radius, out double calculatedArea, out double calculatedCircumference);

                    Console.WriteLine($"Area = {calculatedArea:F2}");
                    Console.WriteLine($"Circumference = {calculatedCircumference:F2}");
                    break;
                }
                Console.WriteLine("Invalid radius! Please enter a valid positive number.");
            }
        }
    }
}
