using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Square
    {
        protected Line SecondSide;
        public Rectangle(): base()
        {
            Console.WriteLine("Введите вторую строну: ");
            SecondSide = new Line(int.Parse(Console.ReadLine()));
        }

        override public double Perimetr { get => (Side.Lenght + SecondSide.Lenght)*2; }
        override public double Area { get => Side.Lenght * SecondSide.Lenght; }
        override public double Diagonal { get => Math.Sqrt(Side.Lenght*Side.Lenght + SecondSide.Lenght* SecondSide.Lenght); }
        public override void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : прямоугольник");
            Console.WriteLine("Диагональ = {0}", Diagonal);
            Console.WriteLine("Периметр = {0}", Perimetr);
            Console.WriteLine("Площадь = {0}", Area);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
