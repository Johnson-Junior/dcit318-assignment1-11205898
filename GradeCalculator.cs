using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numerical grade (0-100): ");
            // Reads input and converts to integer
            int grade = Convert.ToInt32(Console.ReadLine());

            char letterGrade;

            // Determine the letter grade based on the input
            if (grade >= 90)
                letterGrade = 'A';
            else if (grade >= 80)
                letterGrade = 'B';
            else if (grade >= 70)
                letterGrade = 'C';
            else if (grade >= 60)
                letterGrade = 'D';
            else
                letterGrade = 'F';

            Console.WriteLine("Your letter grade is: " + letterGrade);
        }
    }
}
