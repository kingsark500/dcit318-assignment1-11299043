using System;

class MaxTriangleTypeIdentifier
{
    static void Main()

    {

        Console.Write("Enter side 1 length: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter side 2 length: ");
        string input2 = Console.ReadLine();

        Console.Write("Enter side 3 length: ");
        string input3 = Console.ReadLine();

        double side1, side2, side3;

        if (!double.TryParse(input1, out side1) || side1 <= 0 ||
            !double.TryParse(input2, out side2) || side2 <= 0 ||
            !double.TryParse(input3, out side3) || side3 <= 0)

        {
            Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
            return;
        }

        if (side1 == side2 && side2 == side3)

        {
            Console.WriteLine("The triangle is Equilateral.");
        }

        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }

        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }

        Console.ReadLine();
    }
}

