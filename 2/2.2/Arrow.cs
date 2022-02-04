using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    public class Arrow : GameObject
    {
        Direction _direction;
        public bool IsBump { get; set; }
        public Arrow(Coordinates position, Direction direction) : base(position) 
        {
            Icon = "*";
            _direction = direction;
        }

        public void FlightStep()
        {
            if (IsBump)
                return;
            
            switch (_direction)
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

