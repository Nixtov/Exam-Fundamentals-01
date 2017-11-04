using System;
using System.Collections.Generic;
using System.Linq;

class CoffeeOrders
{
    public static void Main()
    {
        int countN = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;
        for (int i = 0; i < countN; i++)
        {
            decimal price = ProgressOrder();
            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
    static decimal ProgressOrder()
    {

        decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

        string dateStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
        decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

        decimal capsulesCount = decimal.Parse(Console.ReadLine());
        decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;

        Console.WriteLine($"The price for the coffee is: ${price:F2}");

        return price;
    }
}

