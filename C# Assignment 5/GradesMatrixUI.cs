using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class GradesMatrixUI
    {
        private const int Students = 3;
        private const int Subjects = 4;

        public void Run()
        {
            int[,] gradesMatrix = new int[Students, Subjects];

            Console.WriteLine($"--- Enter Grades for {Students} Students (Each has {Subjects} Subjects) ---");

            for (int i = 0; i < Students; i++)
            {
                Console.WriteLine($"\nFilling data for Student [{i + 1}]:");
                for (int j = 0; j < Subjects; j++)
                {
                    gradesMatrix[i, j] = ReadValidGrade(j);
                }
            }

            GradesCalculator calculator = new GradesCalculator();

            Console.WriteLine("\n--- Results ---");

            for (int i = 0; i < Students; i++)
            {
                double studentAvg = calculator.CalculateStudentAverage(gradesMatrix, i);
                Console.WriteLine($"Student [{i + 1}] Average Grade = {studentAvg:F2}");
            }

            double classAvg = calculator.CalculateClassAverage(gradesMatrix);
            Console.WriteLine($"\nOverall Class Average = {classAvg:F2}");
        }

        private int ReadValidGrade(int subjectIndex)
        {
            while (true)
            {
                Console.Write($"  Enter grade for Subject [{subjectIndex + 1}]: ");
                if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
                {
                    return grade;
                }
                Console.WriteLine("  Invalid grade! Please enter a valid integer between 0 and 100.");
            }
        }
    }
}

