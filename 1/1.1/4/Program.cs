using System;

namespace task1._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string emptyString = new(' ', n - j - 1);
                    string stars = new('*', j * 2 + 1);
                    Console.WriteLine(emptyString + stars + emptyString);
                }
            }
        }
    }
}
