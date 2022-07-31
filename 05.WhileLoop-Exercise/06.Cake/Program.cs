using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cake = width * lenght;

            while (cake > 0)
            {
                string input = (Console.ReadLine());

                if (input == "STOP")
                {
                    break;
                }

                int currentPeaces = int.Parse(input);
                cake -= currentPeaces;
            }

            if (cake >= 0)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
