using System;

namespace task1._1._9
{
    internal class Program
    {
        public static void GenerateRandomElements(int[] array)
        {
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 5);
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
        }
        public static int PositiveElementsSum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (item >= 0)
                    sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            var array = new int[7];

            Console.WriteLine("Исходный массив");
            GenerateRandomElements(array);
            PrintArray(array);

            Console.Write("Сумма положительных элементов : ");
            Console.WriteLine(PositiveElementsSum(array));
        }
    }
}
