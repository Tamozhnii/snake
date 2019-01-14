﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(100, 50);

            HorizontalLine UpLine = new HorizontalLine(0, 98, 0, '%');
            HorizontalLine DownLine = new HorizontalLine(0, 98, 48, '%');
            VerticalLine LeftLine = new VerticalLine(0, 0, 48, '&');
            VerticalLine RightLine = new VerticalLine(98, 0, 48, '&');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p = new Point(7, 9, '*');
            Snake snake = new Snake(p, 4, direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }
    }
}
