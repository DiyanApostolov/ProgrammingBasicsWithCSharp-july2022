using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            // Calcualtions
            double lihva = deposit * percent / 100;
            double lihvaZaMesec = lihva / 12;

            double sum = deposit + months * lihvaZaMesec;

            //Решение на задачата в един ред
            //double sum = deposit + months * ((deposit * percent / 100) / 12);

            // Output
            Console.WriteLine(sum);
        }
    }
}
