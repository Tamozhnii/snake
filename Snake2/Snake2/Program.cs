using System;
using System.Threading;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(81, 41);
            Console.CursorVisible = false;
            Console.WindowWidth = Console.BufferWidth;
            Console.WindowHeight = Console.BufferHeight;

            Wall w = new Wall(Console.BufferWidth, Console.BufferHeight);

            Snake snake = new Snake(new Point(4, 2, '*'), 4, Direction.RIGHT);

            Food food = new Food(Console.BufferWidth, Console.BufferHeight, '$', snake);
            food.Create();

            new Point(40, 2, '%').Draw();

            while (snake.Collide(w.pList))
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Controle(key.Key);
                }
                Thread.Sleep(100);
                if (snake.Eat(food)) food.Create();
                else snake.Move();

            }
            //Console.SetCursorPosition(65, 2);
            //Console.ReadLine();
        }
    }
}
