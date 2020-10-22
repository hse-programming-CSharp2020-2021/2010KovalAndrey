using System;

namespace Task_6
{
    class Task6
    {
        static double Factorial(int i)
        {
            if (i > 0)
            {
                return i * Factorial(i - 1);
            }
            return 1;
        }
        static double first(double x)
        {
            double old = -1;
            double newnum = 0;
            for (int i = 1; old - newnum != 0.0; i++)
            {
                old = newnum;
                newnum += Math.Pow(-1, i - 1) * Math.Pow(2, 2 * i - 1) * Math.Pow(x, 2 * i) / Factorial(i * 2);
            }
            return newnum;
        }

        static double sec(double x)
        {
            double old = -1;
            double newnum = 1;
            for (int i = 1; old != newnum; i++)
            {
                old = newnum;
                newnum += Math.Pow(x, i) / Factorial(i);
            }
            return newnum;
        }
        static void Main(string[] args)
        {
            double num;
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("Enter num: ");
                } while (!double.TryParse(Console.ReadLine(), out num));
                Console.WriteLine("Value\t|\tFuncFirst\t|\tFuncSecond");
                Console.WriteLine($"{num}\t|\t{first(num):F4}\t\t|\t{sec(num):F4}\n");
                Console.WriteLine("Press ESC to exit, or any other key to continue.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}