using System;

namespace Assignment1
{
    public class TicketPriceCalculator
    {
        public static void CalculateTicketPrice()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
