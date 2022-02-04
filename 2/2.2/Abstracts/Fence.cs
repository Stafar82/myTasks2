using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56.Abstracts
{
    abstract public class Fence : GameObject
    {
        protected Fence(Coordinates coordinates) : base(coordinates)
        {
        }

        protected Fence(string icon) : base(icon)
        {
        }

        protected Fence(Coordinates coordinates, string icon) : base(coordinates, icon)
        {
        }
    }
}
