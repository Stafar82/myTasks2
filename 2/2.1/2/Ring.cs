using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ring : RoundShape
    {
        public Disc inner;
        public Disc outer;

        public Ring(int x, int y, int outerRad, int innerRad) : base(x,y,outerRad)
        {
            inner = new Disc(x,y,innerRad);
            outer = new Disc(x,y,outerRad);
        }

        public Ring() : base()
        {
            Console.WriteLine("Введите внутренний радиус");
            int outerRad = int.Parse(Console.ReadLine());
            inner = new Disc(X, Y, Radius);
            outer = new Disc(X, Y, outerRad);
        }
        public double GetArea() => outer.GetArea() - inner.GetArea();
        public override double GetLenght() => outer.GetLenght() + inner.GetLenght();

        override public void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : кольцо");
            Console.WriteLine("Коодринаты: X = {0}, Y = {1}", X, Y);
            Console.WriteLine("Внутренний радиус = {0}", outer.Radius);
            Console.WriteLine("Внешний радиус = {0}", Radius);
            Console.WriteLine("Длина кольца = {0}", GetLenght());
            Console.WriteLine("Площадь кольца = {0}", GetArea());
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }

    }
}
