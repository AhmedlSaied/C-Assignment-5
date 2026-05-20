using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class GradesCalculator
    {
        public double CalculateStudentAverage(int[,] matrix, int studentIndex)
        {
            int sum = 0;
            int subjectsCount = matrix.GetLength(1);

            for (int j = 0; j < subjectsCount; j++)
            {
                sum += matrix[studentIndex, j];
            }

            return (double)sum / subjectsCount;
        }

        public double CalculateClassAverage(int[,] matrix)
        {
            int totalSum = 0;
            int studentsCount = matrix.GetLength(0); 
            int subjectsCount = matrix.GetLength(1); 
            int totalElements = matrix.Length;       

            for (int i = 0; i < studentsCount; i++)
            {
                for (int j = 0; j < subjectsCount; j++)
                {
                    totalSum += matrix[i, j];
                }
            }

            return (double)totalSum / totalElements;
        }
    }
}
    

