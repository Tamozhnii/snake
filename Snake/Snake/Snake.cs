using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        direction Direction;

        public Snake(Point tail, int Lenght, direction _Direction)
        {
            Direction = _Direction;
            pList = new List<Point>();
            for (int i = 0; i < Lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Drow();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void jostick(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                Direction = direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                Direction = direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                Direction = direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Direction = direction.DOWN;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
