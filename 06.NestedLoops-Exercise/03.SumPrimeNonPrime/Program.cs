using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbers = 0;

            string input = Console.ReadLine();

            while (input != "stop")
            {
                int currentNumber = int.Parse(input);
                int prime = 0;

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");

                    input = Console.ReadLine();
                    continue;
                }

                if (currentNumber == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        prime++;
                    }
                }

                if (prime == 2)
                {
                    sumPrimeNumbers += currentNumber;
                }
                else
                {
                    sumNonPrimeNumbers += currentNumber;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");
        }
    }
}
