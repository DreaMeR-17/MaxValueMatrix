using System;

namespace MaxValueMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxValue = int.MinValue;
            int rowLenght = 10;
            int columnLenght = 10;
            int minRandomValue = 1;
            int maxRandomValue = 10;
            int newValue = 0;

            int[,] numbers = new int[rowLenght, columnLenght];

            Console.WriteLine("\nДана исходная матрица:\n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minRandomValue, maxRandomValue);
                    Console.Write(numbers[i, j] + " ");

                    if (numbers[i, j] > maxValue)
                    {
                        maxValue = numbers[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nМатрица после изменений максимальных значений\n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] == maxValue)
                    {
                        numbers[i, j] = newValue;
                    }

                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nМаксимальное значение в матрице: " + maxValue);
        }
    }
}
