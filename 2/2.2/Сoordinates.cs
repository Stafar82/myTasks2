using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    public struct Coordinates : IComparable<Coordinates>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(Coordinates other)
        {
            if (X == other.X && Y == other.Y)
                return 0;
            else return 1;
        }
    }
}
