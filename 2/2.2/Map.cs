using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    public class Map
    {
        public int Size { get; }

        List<GameObject> gameObjects = new List<GameObject>();

        private Room[,] field;

        public Map(int size)
        {
            Size = size;
            field = new Room[size,size];
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    field[x,y] = new Room();
                }
            }
        }

        public string[] GetField()
        {
            Clear();
            foreach (var gameObject in gameObjects)
            {
                var position = gameObject.Position;
                field[position.X, position.Y].Icon = gameObject.Icon;
            }
            string[] lines = new string[Size];
            for (int y = 0; y < Size ; y++)
            {
                lines[y] = string.Empty;
                for (int x = 0; x < Size; x++)
                {
                    lines[y] += field[x, y].GetRoom();
                }
            }
            return lines;
        }

        public void Add(GameObject gameObject)
        {
            Coordinates coord = gameObject.Position;
            foreach (var item in gameObjects)
            {
                if(gameObject.Position.CompareTo(item.Position) == 0)
                {
                    coord.X = new Random().Next(0, 6);
                    coord.Y = new Random().Next(0, 6);
                }
            }
            field[coord.X, coord.Y] = new Room(gameObject.Icon);
            gameObjects.Add(gameObject);
        }

        public void Remove(GameObject gameObject)
        {
            gameObjects.Remove(gameObject);
        }

        public bool IsOnMap(Coordinates position)
        {
            return ((0 <= position.X && position.X < Size) &&
                    (0 <= position.Y && position.Y < Size));
        }
        private void Clear()
        {
           for (int y = 0; y < Size; y++)
           {
                for (int x = 0; x < Size; x++)
                {
                    field[x, y].Icon = " ";
                }
           }
        }


    }
}
