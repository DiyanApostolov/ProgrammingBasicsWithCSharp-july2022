using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();

            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;

            while (nameOfMovie != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int counter = 0;

                while (freePlaces > counter)
                {
                    string typeOfTicket = Console.ReadLine();

                    if (typeOfTicket == "End")
                    {
                        break;
                    }

                    if (typeOfTicket == "student")
                    {
                        studentCounter++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standardCounter++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidCounter++;
                    }

                    counter++;
                }

                double averagePlaces = counter * 100.0 / freePlaces;
                Console.WriteLine($"{nameOfMovie} - {averagePlaces:F2}% full.");

                nameOfMovie = Console.ReadLine();
            }    

            int allTickets = studentCounter + standardCounter + kidCounter;
            double percentStudendTickets = (double)studentCounter / allTickets * 100;
            double percentStandardTickets = (double)standardCounter / allTickets * 100;
            double precentKidTickets = (double)kidCounter / allTickets * 100;

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{percentStudendTickets:F2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:F2}% standard tickets.");
            Console.WriteLine($"{precentKidTickets:F2}% kids tickets.");
        }
    }
}
