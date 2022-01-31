using System;

namespace ConsoleApp69
{
    internal class Program
    {
        public static void CorrectInputDetect(int a)
        {
            if (a is 0 or < 0)
                throw new ArgumentException();
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите сторону a: ");
            if (int.TryParse(Console.ReadLine(), out a))
                CorrectInputDetect(a);

            Console.Write("Введите сторону b: ");
            if (int.TryParse(Console.ReadLine(), out b))
                CorrectInputDetect(b);

            Console.WriteLine("Площадь треугольника = {0}", a * b);
        }
    }
}
