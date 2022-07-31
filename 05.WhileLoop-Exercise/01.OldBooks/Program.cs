using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int count = 0;

            string currentBook = Console.ReadLine();

            while (currentBook != favouriteBook)
            {
                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }

                count++;

                currentBook = Console.ReadLine();
            }

            if (currentBook == favouriteBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
