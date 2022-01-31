using System;
using System.Text.RegularExpressions;
using System.Text;

namespace task1._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([.!?])";
            var builder = new StringBuilder("я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!");
            var sentenceArray = Regex.Split(builder.ToString(), pattern);

            Console.WriteLine(sentenceArray.Length);
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (sentenceArray[i].Length == 1)
                    continue;
                for (int j = 0; j < sentenceArray[i].Length; j++)
                {
                    if (Char.IsLetter(sentenceArray[i][j]))
                    {
                        string temp = sentenceArray[i];
                        sentenceArray[i] = temp.Remove(0, 1).Insert(0, Char.ToUpper(sentenceArray[i][0]).ToString());
                        break;
                    }
                    else
                    {
                        string temp = sentenceArray[i];
                        sentenceArray[i] = temp.Remove(0, 1);
                    }
                }
            }

            //Не смог использовать стринг джоин т.к вылезали пробелы между разделителями, пришлось костылять. да и сам паттерн не совсем удачный, но работает....
            var result = new StringBuilder();
            for(int i = 0; i < sentenceArray.Length - 1; i++)
            {
                if (sentenceArray[i + 1].Length == 1)
                    result.Append(sentenceArray[i]);
                else
                    result.Append(sentenceArray[i] + ' ');
            }
            Console.WriteLine(result.ToString());
        }
    }
}
