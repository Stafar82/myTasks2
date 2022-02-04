using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class RoundShape : Shape
    {
        public int Radius { get; set; }
        virtual public double GetLenght() => 2 * Math.PI * Radius;
        public RoundShape(int x, int y, int rad) : base(x,y)
        {
            Radius = rad;

        }
        public RoundShape()
        {
            Console.WriteLine("Введите координаты X, Y");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус");
            Radius = int.Parse(Console.ReadLine());
        }

    }
}
