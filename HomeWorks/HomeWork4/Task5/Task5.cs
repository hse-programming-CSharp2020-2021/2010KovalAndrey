using System;

namespace Task_5
{
    class Task5
    {
        static double Sum(uint k)
        {
            double sum = 0;
            for (int i = 1; i < k + 1; i++)
            {
                sum += (k + 0.3) / (3 * k * k + 5);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            uint num;
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("Enter num: ");
                } while (!uint.TryParse(Console.ReadLine(), out num));
                Console.WriteLine("n\t|\tSn");
                for (uint i = 1; i < num + 1; i++)
                {
                    Console.WriteLine($"{i}\t|\t{Sum(i):G4}\n");
                }
                Console.WriteLine("Press ESC to exit, or any other key to continue.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}