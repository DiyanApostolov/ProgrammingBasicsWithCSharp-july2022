﻿using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examSumInMinutes = examHour * 60 + examMinutes;
            int arriveSumInMinutes = arriveHour * 60 + arriveMinutes;

            if (arriveSumInMinutes > examSumInMinutes)
            {
                Console.WriteLine("Late");

                if (arriveSumInMinutes - examSumInMinutes < 60)
                {
                    Console.WriteLine($"{arriveSumInMinutes - examSumInMinutes} minutes after the start");
                }
                else
                {
                    int hours = (arriveSumInMinutes - examSumInMinutes) / 60;
                    int minutes = (arriveSumInMinutes - examSumInMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }
            else if (arriveSumInMinutes == examSumInMinutes || examSumInMinutes - arriveSumInMinutes <= 30)
            {
                Console.WriteLine("On time");

                if (arriveSumInMinutes - examSumInMinutes != 0)
                {
                    Console.WriteLine($"{examSumInMinutes - arriveSumInMinutes} minutes before the start");
                }
            }
            else if (examSumInMinutes - arriveSumInMinutes > 30 )
            {
                Console.WriteLine("Early");

                if (Math.Abs(arriveSumInMinutes - examSumInMinutes) < 60)
                {
                    Console.WriteLine($"{examSumInMinutes - arriveSumInMinutes} minutes before the start");
                }
                else
                {
                    int hours = (examSumInMinutes - arriveSumInMinutes) / 60;
                    int minutes = (examSumInMinutes - arriveSumInMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }
        }
    }
}
