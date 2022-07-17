using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;

            if (typeOfProjection == "Premiere")
            {
                price = 12;
            }
            else if (typeOfProjection == "Normal")
            {
                price = 7.50;
            }
            else if (typeOfProjection == "Discount")
            {
                price = 5;
            }

            int capacity = rows * columns;
            double finlaPrice = capacity * price;

            Console.WriteLine("{0:f2} leva", finlaPrice);
        }
    }
}
