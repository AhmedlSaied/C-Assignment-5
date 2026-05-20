using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class DayCalculator
    {
        public void Run()
        {
            int dayIndex = ReadValidDayNumber();
            DayOfWeek selectedDay = (DayOfWeek)dayIndex;
            switch (selectedDay)
            {
                case DayOfWeek.Saturday:
                    Console.WriteLine("Day: Saturday");
                    Console.WriteLine("It's the Weekend");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Day: Sunday");
                    Console.WriteLine("It's a Workday");
                    break;

                case DayOfWeek.Monday:
                    Console.WriteLine("Day: Monday");
                    Console.WriteLine("It's a Workday");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Day: Tuesday");
                    Console.WriteLine("It's a Workday");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Day: Wednesday");
                    Console.WriteLine("It's a Workday");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Day: Thursday");
                    Console.WriteLine("It's a Workday");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Day: Friday");
                    Console.WriteLine("It's the Weekend");
                    break;
            }

        }

        private int ReadValidDayNumber()
        {
            while (true)
            {
                Console.Write("Enter a day number (1-7): ");

                if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 7)
                {
                    return number-1;
                }

                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            }
        }
    }
}
