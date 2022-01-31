using System;

namespace task1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string message = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            var wordsArray = message.Split(new char[] {',',' ',':','.'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in wordsArray)
            {
                if (Char.IsLower(word[0]))
                    count++;
            }

            Console.WriteLine("Количество слов, начинающихся с маленькой буквы: {0}", count);
        }
    }
}
