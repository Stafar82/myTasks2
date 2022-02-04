using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Disc : RoundShape
    {
        public Disc(int x, int y, int rad) : base(x, y, rad) { }
        public Disc() :base() { }
        public double GetArea() => Math.PI * Radius * Radius;

        override public void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : диск");
            Console.WriteLine("Коодринаты: X = {0}, Y = {1}", X, Y);
            Console.WriteLine("Радиус = {0}", Radius);
            Console.WriteLine("Длина окружности = {0}", GetLenght());
            Console.WriteLine("Площадь окружности = {0}", GetArea());
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }

    }
}
