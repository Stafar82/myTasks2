using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp56
{
    public abstract class GameObject
    {
        protected Coordinates position;
        public Coordinates Position { get => position; protected set => position = value; }
        public string Icon { get; protected set; }

        public GameObject(Coordinates coordinates, string icon)
        {
            Position = coordinates;
            Icon = icon;
        }
        public GameObject(Coordinates coordinates)
        {
            Position = coordinates;
        }

        public GameObject(string icon)
        {
            position.X = new Random().Next(0, 6);
            position.Y = new Random().Next(0, 6);
            Icon = icon;
        }
    }
}
