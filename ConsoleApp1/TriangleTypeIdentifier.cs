
using System;

namespace Assignment1
{
    public class TriangleTypeIdentifier
    {
        public static void IdentifyTriangleType()
        {
            Console.WriteLine("Enter the length of the first side:");
            if (double.TryParse(Console.ReadLine(), out double side1))
            {
                Console.WriteLine("Enter the length of the second side:");
                if (double.TryParse(Console.ReadLine(), out double side2))
                {
                    Console.WriteLine("Enter the length of the third side:");
                    if (double.TryParse(Console.ReadLine(), out double side3))
                    {
                        if (side1 == side2 && side2 == side3)
                            Console.WriteLine("The triangle is Equilateral.");
                        else if (side1 == side2 || side2 == side3 || side1 == side3)
                            Console.WriteLine("The triangle is Isosceles.");
                        else
                            Console.WriteLine("The triangle is Scalene.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for the third side. Please enter a valid length.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the second side. Please enter a valid length.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first side. Please enter a valid length.");
            }
        }
    }
}

