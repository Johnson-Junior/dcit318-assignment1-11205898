using System;

namespace TriangleTypeID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Check the type of triangle based on the equality of sides
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}


