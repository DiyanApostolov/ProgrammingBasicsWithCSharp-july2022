using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            switch (flowers)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }

            double finalPrice = countOfFlowers * price;

            if (flowers == "Roses" && countOfFlowers > 80)
            {
                finalPrice *= 0.9;
            }
            else if (flowers == "Dahlias" && countOfFlowers > 90)
            {
                finalPrice *= 0.85;
            }
            else if (flowers == "Tulips" && countOfFlowers > 80)
            {
                finalPrice *= 0.85;
            }
            else if (flowers == "Narcissus" && countOfFlowers < 120)
            {
                finalPrice *= 1.15;
            }
            else if (flowers == "Gladiolus" && countOfFlowers < 80)
            {
                finalPrice *= 1.2;
            }

            double difference = Math.Abs(finalPrice - budget);

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowers} and {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
            }
        }
    }
}
