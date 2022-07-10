using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsForMeter = double.Parse(Console.ReadLine());

            double distanceToSwimInSecond = distanceInMetres * timeInSecondsForMeter;
            double waterResistance = Math.Floor(distanceInMetres / 15);
            double addetTime = waterResistance * 12.5;

            double finalTimeForSwim = distanceToSwimInSecond + addetTime;

            bool isRecordBeat = finalTimeForSwim < worldRecord;

            if (isRecordBeat)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTimeForSwim:F2} seconds.");
            }
            else
            {
                double needenSeconds = Math.Abs(worldRecord - finalTimeForSwim);
                Console.WriteLine($"No, he failed! He was {needenSeconds:F2} seconds slower.");
            }
        }
    }
}
