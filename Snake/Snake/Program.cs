using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(100, 50);

            Walls walls = new Walls(100, 50);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, direction.RIGHT);
            Draw(snake);

            FoodCreator foodCreator = new FoodCreator(100, 50, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.jostick(key.Key);
                }
            }


            //VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            //Draw(v1);
            //HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            //List<Figure> figures = new List<Figure>();
            //figures.Add(snake);
            //figures.Add(v1);
            //figures.Add(h1);

            //foreach(var f in figures)
            //{
            //    f.Draw();
            //}

            //while (true)
            //{
            //    if (snake.Eat(food))
            //    {
            //        food = foodCreator.CreateFood();
            //        food.Draw();
            //    }
            //    else
            //    {
            //        snake.Move();
            //    }

            //    Thread.Sleep(100);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.jostick(key.Key);
            //    }
            //    Thread.Sleep(100);
            //    snake.Move();
            //}

        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }

    }
}
