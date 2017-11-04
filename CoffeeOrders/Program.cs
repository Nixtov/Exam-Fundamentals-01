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
        throw new NotImplementedException();
    }
}

