using System;

namespace task1._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string emptyString = new string(' ', n - i - 1);
                string stars = new ('*', i * 2 + 1 );
                Console.WriteLine(emptyString + stars + emptyString);
            }
        }
    }
}
