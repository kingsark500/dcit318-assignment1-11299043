using System;

class MaxTicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        int age;

        if (!int.TryParse(input, out age) || age < 0)
        {

            Console.WriteLine("Invalid input. Please enter a valid non-negative age.");

            return;

        }

        int ticketPrice;

        if (age >= 65 || age <= 12)
        {

            ticketPrice = 7;

        }

        else
        {

            ticketPrice = 10;

        }

        Console.WriteLine($"The ticket price is: GHC{ticketPrice}");

        Console.ReadLine();
    }
}
