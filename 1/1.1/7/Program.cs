using System;

namespace task1._1._7
{
    internal class Program
    {
        public static void WriteMinAndMaxElements(int[] array)
        {
            int min = int.MaxValue;
            int max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                    max = array[i];

                if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine("\nМинимальный элемент массива : {0} \nМаксимальный элемент массива : {1}", min, max);
        }
        public static void SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void GenerateRandomElements(int[] array)
        {
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach(var item in array)
                Console.Write(item + " ");
        }
        static void Main(string[] args)
        {
            var array = new int[10];
            GenerateRandomElements(array);

            Console.WriteLine("Исходный массив");
            PrintArray(array);

            Console.WriteLine("\nОтсортированный массив");
            SortArray(array);
            PrintArray(array);
            WriteMinAndMaxElements(array);
        }
    }
}
