using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Shape() 
        {
        }
        abstract public void Print();
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
