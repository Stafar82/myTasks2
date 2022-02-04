using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle : Shape
    {
        private Line LeftSide;
        private Line RightSide;
        private Line BottomSide;
        public string Type { get; }
        private double HaflPerimetr;

        public Triangle()
        {
            Console.WriteLine("Введите длину левой стороны");
            LeftSide = new Line(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите длину правой стороны");
            RightSide = new Line(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите длину нижней стороны");
            BottomSide = new Line(int.Parse(Console.ReadLine()));

            if (LeftSide.Lenght == RightSide.Lenght && LeftSide.Lenght == BottomSide.Lenght)
                Type = "Равносторонний";
            if (LeftSide.Lenght == RightSide.Lenght || LeftSide.Lenght == BottomSide.Lenght)
                Type = "Равнобедренный";
            else
                Type = "Разносторонний";

            HaflPerimetr = (LeftSide.Lenght + RightSide.Lenght + BottomSide.Lenght) / 2.0;
        }

        public double Perimetr
        {
            get => Math.Sqrt(HaflPerimetr * (HaflPerimetr - LeftSide.Lenght) * (HaflPerimetr - RightSide.Lenght) * (HaflPerimetr - BottomSide.Lenght));
        }

        public double Area
        {
            get => 1 / 2 * (BottomSide.Lenght * (2 * Math.Sqrt(HaflPerimetr * (HaflPerimetr - LeftSide.Lenght) * (HaflPerimetr - RightSide.Lenght) * (HaflPerimetr - BottomSide.Lenght) / LeftSide.Lenght)));
        }
        public override void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : треугольник");
            Console.WriteLine("Периметр : {0}", Perimetr);
            Console.WriteLine("Площадь : {0}", Area);
            Console.WriteLine("Тип : {0}", Type);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
