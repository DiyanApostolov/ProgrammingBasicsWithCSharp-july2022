using System;

namespace _05.GodzillaVersusKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfPeople = int.Parse(Console.ReadLine());
            double priceForOneSuith = double.Parse(Console.ReadLine());

            double clothesPrice = countOfPeople * priceForOneSuith;
            double decor = 0.1 * budget;



            if (countOfPeople > 150)
            {
                clothesPrice = 0.9 * clothesPrice;
            }

            double expenses = decor + clothesPrice;

            if (expenses > budget)
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expenses - budget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                double moneyLeft = budget - expenses;
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
