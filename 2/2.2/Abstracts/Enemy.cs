using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56.Abstracts
{
    abstract public class Enemy : GameObject, IMovable
    {
        protected Enemy(Coordinates coordinates) : base(coordinates)
        {
        }

        protected Enemy(string icon) : base(icon)
        {
        }

        protected Enemy(Coordinates coordinates, string icon) : base(coordinates, icon)
        {
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    position.Y--;
                    break;
                case Direction.Left:
                    position.X--;
                    break;
                case Direction.Right:
                    position.X++;
                    break;
                case Direction.Down:
                    position.Y++;
                    break;
            }
        }
    }
}
