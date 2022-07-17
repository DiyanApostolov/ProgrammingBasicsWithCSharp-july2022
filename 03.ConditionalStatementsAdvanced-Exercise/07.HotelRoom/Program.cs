using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartment = 0;

            //May, June, July, August, September или October
            if (month == "May" || month == "October")
            {
                priceForStudio = 50;
                priceForApartment = 65;

                if (night > 7 && night <= 14)
                {
                    priceForStudio *= 0.95;
                }
                else if (night > 14) 
                {
                    priceForStudio *= 0.7;
                    priceForApartment *= 0.9;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 75.20;
                priceForApartment = 68.70;

                if (night >14)
                {
                    priceForStudio *= 0.8;
                    priceForApartment *= 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceForStudio = 76;
                priceForApartment = 77;

                if (night > 14)
                {
                    priceForApartment *= 0.9;
                }
            }

            double finalPriceForStudio = night * priceForStudio;
            double finalPriceForApartment = night * priceForApartment;

            Console.WriteLine($"Apartment: {finalPriceForApartment:F2} lv.");
            Console.WriteLine($"Studio: {finalPriceForStudio:F2} lv.");
        }
    }
}
