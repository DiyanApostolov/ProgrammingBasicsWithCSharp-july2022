using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            bool isBiger = false;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNumber > number)
                    {
                        isBiger = true;
                        break;
                    }

                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                }

                if (isBiger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
