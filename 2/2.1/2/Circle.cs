using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : RoundShape
    {
        public Circle() : base() { }

        public Circle(int x, int y, int rad) : base(x, y, rad) { }

        override public void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : окружность");
            Console.WriteLine("Коодринаты: X = {0}, Y = {1}", X, Y);
            Console.WriteLine("Радиус = {0}", Radius);
            Console.WriteLine("Длина окружности = {0}", GetLenght());
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }

    }
}
