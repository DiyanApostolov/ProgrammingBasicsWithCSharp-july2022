using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int homeFreeSpace = width * lenght * hight;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int currentBox = int.Parse(input);
                homeFreeSpace -= currentBox;

                if (homeFreeSpace <= 0)
                {
                    int difference = Math.Abs(homeFreeSpace);
                    Console.WriteLine($"No more free space! You need {difference} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (homeFreeSpace > 0)
            {
                Console.WriteLine($"{homeFreeSpace} Cubic meters left.");
            }
        }
    }
}
