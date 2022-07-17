using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spendMoney = 0;
            string typeOfRest = string.Empty;
            string destination = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    spendMoney = budget * 0.3;
                    typeOfRest = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.7;
                    typeOfRest = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    spendMoney = budget * 0.4;
                    typeOfRest = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.8;
                    typeOfRest = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendMoney = budget * 0.9;
                typeOfRest = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfRest} - {spendMoney:F2}");
        }
    }
}
