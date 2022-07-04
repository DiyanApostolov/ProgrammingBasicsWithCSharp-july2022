using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            // Calculations
            double volumeOfAquarium = lenght * width * height;
            double volumeInLitres = volumeOfAquarium * 0.001;  //volumeOfAquarium / 1000.0
            double sumLitres = volumeInLitres * (1 - percentage / 100);

            // Output
            Console.WriteLine(sumLitres);
        }
    }
}
