using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

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

        public void Move(int offset, direction Direction)
        {
            if(Direction == direction.RIGHT)
            {
                x = x + offset;
            }
            else if(Direction == direction.LEFT)
            {
                x = x - offset;
            }
            else if(Direction == direction.UP)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(4, 5);
            Console.Write(sym);
        }
    }
}
