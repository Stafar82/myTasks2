using System;

namespace task2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            string message = "Привчедел делаем новую версию веслолопаты, лепим пьезу на Юность";
            string[] stringArray = message.Split(new char[] { ' ', ',', '!'}, StringSplitOptions.RemoveEmptyEntries);
            foreach(var word in stringArray)
            {
                length += word.Length;
            }

            Console.WriteLine("Средняя длина слов = {0}", length / stringArray.Length);
        }
    }
}
