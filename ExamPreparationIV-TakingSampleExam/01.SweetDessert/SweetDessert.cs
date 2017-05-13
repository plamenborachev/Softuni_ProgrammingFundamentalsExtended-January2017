using System;

namespace _01.SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            int portions = guests / 6;

            if (guests % 6 != 0)
            {
                portions++;
            }

            decimal productsPricePerPortion = 2 * bananaPrice + 4 * eggPrice + 0.2m * berriesPrice;

            decimal productsPriceTotal = portions * productsPricePerPortion;

            if (productsPriceTotal <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {productsPriceTotal:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {productsPriceTotal - cash:F2}lv more.");
            }

        }
    }
}
