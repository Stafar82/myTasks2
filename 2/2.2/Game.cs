using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using ConsoleApp56.Abstracts;

namespace ConsoleApp56
{
    public class Game
    {
        private List<GameObject> Objects;
        private List<GameObject> Fences;
        private List<GameObject> Enemies;
        private List<GameObject> Bonuses;
        private readonly Map map;
        private readonly Player player;
        bool isWorking = false;
        private int lives = 1;
        private int refresh = 200;
        public Game()
        {
            map = new Map(10);
            player = new Player("@");
            map.Add(player);

            Objects = new List<GameObject> 
            {
                new Wolf("W"), new Bear("B"), 
                new Wolf("W"), new Bear("B"), 
                new Apple("o"), new Apple("o")
            };

            for (int i = 0; i < 12; i++)
                Objects.Add(new Barricades("#"));

            for (int i = 0; i < Objects.Count; i++)
            {
                map.Add(Objects[i]);
            }

            Enemies = Objects.Where(t => t is Enemy).ToList();
            Fences = Objects.Where(t => t is Fence).ToList();
            Bonuses = Objects.Where(t => t is Bonus).ToList();
        }
        public void Start()
        {
            while (!isWorking) 
            {
                RefreshMap();
                Console.WriteLine("Количество жизней: {0}", lives);
                SecretMethod();

                ConsoleKeyInfo userInput = Console.ReadKey(true);

                ActionHeandler(userInput);

            }
        }

        public void ActionHeandler(in ConsoleKeyInfo userInput)
        {
            switch (userInput.Key)
            {
                case ConsoleKey.UpArrow:
                    if (isNotOutsideOrFence(Direction.Up, player.Position))
                    {
                        player.Move(Direction.Up);
                        EnemyMovements(Direction.Down, Enemies);
                        BonusChecker(player.Position);
                        EnemysChecker(player.Position);
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (isNotOutsideOrFence(Direction.Left, player.Position))
                    {
                        player.Move(Direction.Left);
                        EnemyMovements(Direction.Right, Enemies);
                        BonusChecker(player.Position);
                        EnemysChecker(player.Position);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (isNotOutsideOrFence(Direction.Right, player.Position))
                    {
                        player.Move(Direction.Right);
                        EnemyMovements(Direction.Left, Enemies);
                        BonusChecker(player.Position);
                        EnemysChecker(player.Position);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (isNotOutsideOrFence(Direction.Down, player.Position))
                    {
                        player.Move(Direction.Down);
                        EnemyMovements(Direction.Up, Enemies);
                        BonusChecker(player.Position);
                        EnemysChecker(player.Position);
                    }
                    break;

                case ConsoleKey.W:
                    Fire(player.Position, Direction.Up);
                    break;
                case ConsoleKey.A:
                    Fire(player.Position, Direction.Left);
                    break;
                case ConsoleKey.D:
                    Fire(player.Position, Direction.Right);
                    break;
                case ConsoleKey.S:
                    Fire(player.Position, Direction.Down);
                    break;
            }
        }

        public void Fire(Coordinates position, Direction direction)
        {
            Coordinates positionArrow = new Coordinates(-1, 0);
            switch (direction)
            {
                case Direction.Up:
                    if (isNotOutsideOrFence(Direction.Up, player.Position))
                        positionArrow = new Coordinates(position.X, position.Y - 1);
                    break;

                case Direction.Left:
                    if (isNotOutsideOrFence(Direction.Left, player.Position))
                        positionArrow = new Coordinates(position.X - 1, position.Y);
                    break;

                case Direction.Right:
                    if (isNotOutsideOrFence(Direction.Right, player.Position))
                        positionArrow = new Coordinates(position.X + 1, position.Y);
                    break;

                case Direction.Down:
                    if (isNotOutsideOrFence(Direction.Down, player.Position))
                        positionArrow = new Coordinates(position.X, position.Y + 1);
                    break;

                default:
                    return;
            }

                var arrow = new Arrow(positionArrow, direction);
                map.Add(arrow);

                while (map.IsOnMap(arrow.Position) && !arrow.IsBump)
                {
                    for(int i = 0; i < Objects.Count; i++)
                    {
                        {
                            if (arrow.Position.CompareTo(Objects[i].Position) == 0 && Objects[i] is Enemy)
                            {
                                map.Remove(Objects[i]);
                                Objects.Remove(Objects[i]);
                                arrow.IsBump = true;
                            }
                            if(!isNotOutsideOrFence(direction, arrow.Position))
                            {
                                arrow.IsBump = true;
                            }
                        }
                    }
                    RefreshMap();
                    arrow.FlightStep();
                    Thread.Sleep(refresh);
                }
                map.Remove(arrow);

        }
        private bool isNotOutsideOrFence(Direction direction, Coordinates position)
        {
            switch (direction)
            {
                case Direction.Up:
                    return position.Y - 1 >= 0 && !Fences.Where(t => t.Position.Y == position.Y - 1 && t.Position.X == position.X).Any();

                case Direction.Left:
                    return position.X - 1 >= 0 && !Fences.Where(t => t.Position.Y == position.Y && t.Position.X == position.X - 1).Any();

                case Direction.Right:
                    return position.X + 1 < map.Size && !Fences.Where(t => t.Position.Y == position.Y && t.Position.X == position.X + 1).Any();

                case Direction.Down:
                    return position.Y + 1 < map.Size && !Fences.Where(t => t.Position.Y == position.Y && t.Position.X == position.X).Any();
                default:
                    return false;
            }
        }

        private void EnemyMovements(Direction direction, List<GameObject> Enemys)
        {
            for (int i = 0; i < Enemys.Count; i++)
            {
                if (isNotOutsideOrFence(direction, Enemys[i].Position))
                {
                    var temp = (IMovable)Enemys[i];
                    temp.Move(direction);
                    Objects.Remove(Enemys[i]);
                    map.Remove(Enemys[i]);

                    //Objects.Add((GameObject)temp);
                    //map.Add((GameObject)temp);
                    break;
                }
            }
        }
        private void BonusChecker(Coordinates position)
        {
            foreach(var bonus in Bonuses)
            {
                if (position.CompareTo(bonus.Position) == 0)
                {
                    lives++;
                    Objects.Remove(bonus);
                    map.Remove(bonus);
                }

            }
        }
        private void EnemysChecker(Coordinates position)
        {
            foreach (var enemy in Enemies)
            {
                if (position.CompareTo(enemy.Position) == 0)
                {
                    if (lives == 1)
                    {
                        while(true)
                            Console.WriteLine("\t\t\t\t\t\n\n\n\n\n\nПоздравляю, вы проиграли !");
                    }
                    else
                        lives--;
                }

            }
        }
        private void PrintMap()
        {
            foreach (var line in map.GetField())
            {
                Console.WriteLine(line);
            }
        }

        private void SecretMethod()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
░░░░░░░░▄▄▄▄▄▄▄▄▄
░▄███████▀▀▀▀▀▀███████▄
░▐████▀▒▒▒▒▒▒▒▒▒▒▀██████▄ @ - tbl
░███▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀█████ # - stenki(walls)
░▐██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████▌W, B - vragi (enemys)
░▐█▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████▌o - bonuses(bonuses)
░░█▒▄▀▀▀▀▀▄▒▒▄▀▀▀▀▀▄▒▐███▌wasd - to kill vragov
░░░▐░░░▄▄░░▌▐░░░▄▄░░▌▐███▌
░▄▀▌░░░▀▀░░▌▐░░░▀▀░░▌▒▀▒█▌
░▌▒▀▄░░░░▄▀▒▒▀▄░░░▄▀▒▒▄▀▒▌
░▀▄▐▒▀▀▀▀▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒█
░░░▀▌▒▄██▄▄▄▄████▄▒▒▒▒█▀
░░░░▄██████████████▒▒▐▌
░░░▀███▀▀████▀█████▀▒▌
░░░░░▌▒▒▒▄▒▒▒▄▒▒▒▒▒▒▐
░░░░░▌▒▒▒▒▀▀▀▒▒▒▒▒▒▒▐");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void RefreshMap()
        {
            Console.Clear();
            PrintMap();
        }
    }
}