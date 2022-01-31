using System;
using System.Linq;
using System.Text;

namespace task1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "вот такая вот строка";
            string symbolsToDouble = "вота";
            var charArray = symbolsToDouble.ToCharArray();

            var builder = new StringBuilder(message);
            for(int i = 0; i < builder.Length; i++)
            {
                if (charArray.Contains(builder[i]))
                {
                    builder.Insert(i, builder[i]);
                    i++;
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
