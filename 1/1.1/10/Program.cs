using System;

namespace taskt1._1._10
{
    internal class Program
    {
        public static void GenerateRandomElements(int[,] array)
        {
            var random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    array[i,j] = random.Next(0, 5);
            }
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");
            }
        }

        public static int Solution(int [,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 3;
            var array = new int[n,n];

            Console.WriteLine("Исходный массив");
            GenerateRandomElements(array);
            PrintArray(array);

            Console.Write("Сумма элементов на четных позициях : ");
            Console.WriteLine(Solution(array));
        }
    }
}
