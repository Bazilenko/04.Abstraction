using System;
class Program
{
    static void Main()
    {
        string senum, denum;
        bool exist = true;
        PriceCalculator customer = new PriceCalculator();
        do
        {
            Console.WriteLine("Enter price per day: ");
            customer.PricePerDay = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of days: ");
            customer.NumberOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter season");
            senum = Console.ReadLine();
            if (Enum.TryParse(senum, true, out Seasons season) && Enum.IsDefined(typeof(Seasons), season))
            {
                exist = true;
                customer.Season = season;
            }
            else
            {
                exist = false;
                Console.WriteLine("Invalid season entered.");
            }
            Console.WriteLine("Enter discount: ");
            denum = Console.ReadLine();
            if (Enum.TryParse(denum, true, out Discount discount) && Enum.IsDefined(typeof(Discount), discount))
            {
                exist = true;
                customer.DiscountType = discount;
            }
            else
            {
                exist = false;
                Console.WriteLine("Invalid season entered.");
            }
        } while(!exist);
        Console.WriteLine($"General price: {customer.Calculate()}");

    }
}