using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56.Abstracts
{
    abstract public class Bonus : GameObject
    {
        protected Bonus(Coordinates coordinates) : base(coordinates)
        {
        }

        protected Bonus(string icon) : base(icon)
        {
        }

        protected Bonus(Coordinates coordinates, string icon) : base(coordinates, icon)
        {
        }
    }
}
