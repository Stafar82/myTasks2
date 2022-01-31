using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Line : Shape
    {
        public int Lenght { get; set; }
        public Line(int lenght)
        {
            Lenght = lenght;
        }
        public Line()
        {
            Console.WriteLine("Введите длину линии");
            Lenght = int.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : линия");
            Console.WriteLine("Длина: {0}", Lenght);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
