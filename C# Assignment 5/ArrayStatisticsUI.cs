using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class ArrayStatisticsUI
    {
        public void Run()
        {
            
            int size = ReadValidSize();
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = ReadValidElement(i);
            }

     
            ArrayCalculator calculator = new ArrayCalculator();

            int sum = calculator.CalculateSum(numbers);
            double average = calculator.CalculateAverage(sum, size);
            int max = calculator.FindMax(numbers);
            int min = calculator.FindMin(numbers);

           
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");

          
            Console.Write("Reverse = ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        private int ReadValidSize()
        {
            while (true)
            {
                Console.Write("Enter array size: ");
                if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
                {
                    return size;
                }
                Console.WriteLine("Invalid size! Please enter a positive integer.");
            }
        }

        private int ReadValidElement(int index)
        {
            while (true)
            {
                Console.Write($"Enter element [{index}]: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    return element;
                }
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
    }
}
