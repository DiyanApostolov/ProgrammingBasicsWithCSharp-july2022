﻿using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants
            double priceForPens = 5.8;
            double priceForMarkers = 7.2;
            double priceForPreparat = 1.2;

            // Input
            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            int litresPreparat = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            // Calculations
            double finalPriceForPens = priceForPens * numberOfPens;
            double finalPriceForMarkers = priceForMarkers * numberOfMarkers;
            double finalPriceForPreparat = priceForPreparat * litresPreparat;
            double sum = finalPriceForPens + finalPriceForMarkers + finalPriceForPreparat;

            double finalPrice = sum - (sum * percent / 100);

            // Output
            Console.WriteLine(finalPrice);
        }
    }
}
