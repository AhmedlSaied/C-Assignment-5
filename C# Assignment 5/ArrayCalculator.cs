using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public  class ArrayCalculator
    {
            public int CalculateSum(int[] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }

            public double CalculateAverage(int sum, int size)
            {
                return (double)sum / size;
            }

            public int FindMax(int[] numbers)
            {
                int max = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;
            }

            public int FindMin(int[] numbers)
            {
                int min = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            }
        }
    }

