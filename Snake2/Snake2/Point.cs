using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Snake2
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point() { }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        internal void Move(int i, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    x -= i;
                    break;
                case Direction.RIGHT:
                    x += i;
                    break;
                case Direction.UP:
                    y -= i;
                    break;
                case Direction.DOWN:
                    y += i;
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            if (x > 0 && x < Console.BufferWidth && y > 0 && y < Console.BufferHeight)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
            }
            else Console.Clear();
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool Collide(List<Point> points)
        {
            foreach(var p in points)
            {
                if (p.x == this.x && p.y == this.y) return true;
            }
            return false;
        }

        public bool Collide(Point point)
        {
            if (point.x == this.x && point.y == this.y) return true;
            else return false;
        }
    }
}
