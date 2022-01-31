using System;

namespace task1._1._8
{
    internal class Program
    {
        private static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int z = 0; z < array.GetLength(02); z++)
                    {
                        Console.Write(array[i, j, z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine('\n');
            }
        }

        public static void Solution(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        if (array[i, j, z] > 0)
                            array[i, j, z] = 0;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,,] array =
            {
                {
                    {2,-3,5 },
                    {-69,7,-4}
                },

                {
                    {-2,3,-5 },
                    {69,-7,4 }
                }
            };
            Solution(array);
            PrintArray(array);
        }
    }
}
