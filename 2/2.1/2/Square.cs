using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Square : Shape
    {
        protected Line Side;
        public Square()
        {
            Console.WriteLine("Введите длину стороны");
            Side = new Line(int.Parse(Console.ReadLine()));
        }
        virtual public double Diagonal { get => Math.Sqrt(2) * Side.Lenght; }
        virtual public double Perimetr { get => Side.Lenght * 4; }
        virtual public double Area { get => Side.Lenght * Side.Lenght; }
        override public void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : квадрат");
            Console.WriteLine("Диагональ = {0}", Diagonal);
            Console.WriteLine("Периметр = {0}", Perimetr);
            Console.WriteLine("Площадь = {0}", Area);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
