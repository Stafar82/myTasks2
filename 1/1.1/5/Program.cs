using System;

namespace task1._1._5
{
    internal class Program
    {
        public static int DigitsSum(int digit)
        {
            int digitsSum = 0;
            for(int i = digit; i < 1000; i += digit)
            {
                digitsSum += i;
            }
            return digitsSum;
        }
        static void Main(string[] args)
        {
            int result = DigitsSum(5) + DigitsSum(3) - DigitsSum(15);
            Console.WriteLine(result);
        }
    }
}
