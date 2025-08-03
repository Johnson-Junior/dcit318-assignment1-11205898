using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            // Reads input and converts to integer
            int age = Convert.ToInt32(Console.ReadLine());
            int ticketPrice;

            // Check for discount eligibility
            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7; // Discounted price
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            Console.WriteLine("The ticket price is: GHC" + ticketPrice);
        }
    }
}
