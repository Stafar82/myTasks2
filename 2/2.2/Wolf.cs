using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    public class Wolf : GameObject, IEnemy
    {
        public Wolf(Coordinates coordinates, string icon) : base(coordinates, icon) { }
        public Wolf(string icon) : base(icon) { }

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

        public void Hello()
        {
            throw new NotImplementedException();
        }
    }
}
