using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfVideoCards = int.Parse(Console.ReadLine());
            int CountOfProcessor = int.Parse(Console.ReadLine());
            int countOfRamMemory = int.Parse(Console.ReadLine());

            double priceForVideoCard = 250;
            double sumVideoCards = countOfVideoCards * priceForVideoCard;

            double pricePerProcessor = sumVideoCards * 0.35;
            double sumProcessor = CountOfProcessor * pricePerProcessor;

            double pricePerRam = sumVideoCards * 0.10;
            double sumRam = pricePerRam * countOfRamMemory;

            double fullPrice = sumProcessor + sumRam + sumVideoCards;

            if (countOfVideoCards > CountOfProcessor)
            {
                fullPrice = fullPrice - (fullPrice * 0.15);
            }
            else
            {
                fullPrice = sumProcessor + sumRam + sumVideoCards;
            }

            if (budget >= fullPrice)
            {
                double moneyLeft = budget - fullPrice;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = fullPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
