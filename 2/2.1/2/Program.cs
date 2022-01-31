using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    enum ShapeType
    {
        Circle,
        Disc,
        Ring,
        Square,
        Rectangle,
        Line,
        Triangle

    }
    internal class Program
    {
        public static void SetUsername(string name)
        {
            Console.WriteLine("Здравствуйте, введите ваше новое имя: ");
            name = Console.ReadLine();
        }
        public static void CreateShape(ShapeType shape, List<Shape> list)
        {
            switch (shape)
            {
                case ShapeType.Circle:
                    list.Add(new Circle());
                    break;

                case ShapeType.Disc:
                    list.Add(new Disc());
                    break;

                case ShapeType.Ring:
                    list.Add(new Ring());
                    break;

                case ShapeType.Square:
                    list.Add(new Square());
                    break;
                case ShapeType.Rectangle:
                    list.Add(new Rectangle());
                    break;
                case ShapeType.Line:
                    list.Add(new Line());
                    break;
                case ShapeType.Triangle:
                    list.Add(new Triangle());
                    break;
            }
        }
        public static void PrintShapes(List<Shape> list)
        {
            foreach (var shape in list)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                shape.Print();
            }
        }
        static void Main(string[] args)
        {
            string userName = null;
            var canvas = new List<Shape>();
            bool exit = false;

            Console.WriteLine("Здравствуйте, введите ваше имя: ");
            userName = Console.ReadLine();
            while (!exit)
            {
                Console.WriteLine("Hello, {0}, make a choice", userName);
                Console.WriteLine("1. добавить фигуру\n2. вывести фигуры\n3. очистить холст\n 4. сменить пользователя");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nВведите тип фигуры: ");
                        Console.WriteLine("0 - Окружность, 1 - Диск, 2 - Кольцо, 3 - Квадрат, 4 - Прямоугольник, 5 - Линия, 6 - Треугольник");
                        ShapeType key = (ShapeType)int.Parse(Console.ReadLine());
                        CreateShape(key, canvas);
                        break;
                    case ConsoleKey.D2:
                        PrintShapes(canvas);
                        break;
                    case ConsoleKey.D3:
                        canvas.Clear();
                        Console.WriteLine("Холст очищен!");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nЗдравствуйте, введите ваше новое имя: ");
                        userName = Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
