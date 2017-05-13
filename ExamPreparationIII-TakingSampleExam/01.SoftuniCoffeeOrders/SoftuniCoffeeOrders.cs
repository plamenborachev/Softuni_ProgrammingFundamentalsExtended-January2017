using System;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalCoffeePrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal coffeePrice = (daysInMonth * (long)capsulesCount) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");

                totalCoffeePrice += coffeePrice;
            }

            Console.WriteLine($"Total: ${totalCoffeePrice:F2}");
        }
    }
}
