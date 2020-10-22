using System;

namespace Task_8
{
    class Program
    {
        static void CW(double[] arr)
        {
            for (int i = 1; i < arr.Length + 1; i++)
            {
                Console.WriteLine($"Element {i} is {arr[i - 1]}");
            }
        }
        static double[] CreateArr(uint num)
        {
            double[] array = new double[num];

            for (int i = 0; i < num; i++)
            {
                array[i] = i * (i + 1) / 2 % num;
            }

            return array;
        }
        static void Main(string[] args)
        {
            uint num;
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("Enter num of elements in array: ");
                } while (!uint.TryParse(Console.ReadLine(), out num));

                CW(CreateArr(num));

                Console.WriteLine("\nType 'exit' to exit the program, press 'Enter' to continue... ");
            } while (Console.ReadLine() != "exit");
        }
    }
}