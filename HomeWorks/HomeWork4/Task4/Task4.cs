using System;
using static System.Console;

namespace HomeWork4
{
    class Task4
    {
        static void Sums(uint num, out uint sumE, out uint sumO)
        {
            sumE = 0;
            sumO = 0;
            while (num > 0)
            {
                sumE += num % 10;
                num /= 10;
                sumO += num % 10;
                num /= 10;
            }
        }
        static void Main(string[] args)
        {
            uint number;
            do
            {
                Clear();
                do
                {
                    Write("Enter your number: ");
                } while (!uint.TryParse(ReadLine(), out number));
                Sums(number, out var sumE, out var sumO);
                WriteLine($"Sum of even digits: {sumE}");
                WriteLine($"The same, but for odds: {sumO}");
                WriteLine("Press ESC to exit, or press any other button to continue.");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
            //New update
        }
    }
}