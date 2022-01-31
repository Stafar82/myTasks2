using System;
using System.Collections.Generic;

namespace task1._1._6
{
    internal class Program
    {
        static void WriteInterface(List<string> parameters, List<string> buff)
        {
            if (buff.Count == 0)
                Console.WriteLine("Параметры надписи : None");
            else
            {
                Console.Write("Параметры надписи : ");
                for (int i = 0; i < buff.Count; i++)
                    Console.Write (buff[i] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Введите: ");
            for (int i = 0; i < parameters.Count; i++)
                Console.WriteLine($"\t {i + 1}: {parameters[i]}");
        }

        static void Trigger(string type, List<string> buffer)
        {
            if (buffer.Contains(type))
                buffer.Remove(type);
            else
                buffer.Add(type);
        }
        static void Main(string[] args)
        {
            string bold = "Bold";
            string italic = "Italic";
            string underline = "Underline";
            var parameters = new List<string> { bold, italic, underline};
            var buffer = new List<string> ();

            while (true)
            {
                WriteInterface(parameters, buffer);
                char inputKey = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (inputKey)
                {
                    case '1':
                        Trigger("Bold", buffer);
                        break;
                    case '2':
                        Trigger("Italic", buffer);
                        break;
                    case '3':
                        Trigger("Underline", buffer);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
