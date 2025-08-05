using System;

public class MaxGradeCalculator
{

    static void Main()
    {
        Console.WriteLine("Enter a numerical grade betwwen 0 and 100:");

        string input = Console.ReadLine();
        int grade;

        if (!int.TryParse(input, out grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input, write a number between 1 and 100");
            return;
        }

        char letterGrade;

        if (grade >= 90)
        {
            letterGrade = 'A';
        }

        else if (grade >= 80)
        {
            letterGrade = 'B';
        }

        else if (grade >= 70)
        {
            letterGrade = 'C';
        }

        else
        {
            letterGrade = 'F';
        }

        Console.WriteLine($"The grade is : {letterGrade}");

        Console.ReadLine();
    }
}
