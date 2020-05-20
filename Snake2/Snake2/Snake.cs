using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake2
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
            Draw();
        }

        internal void Move()
        {
            pList.First().Clear();
            pList.Remove(pList.First());
            pList.Add(GetNextPoint());
            pList.Last().Draw();
        }

        public void Controle(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            else if (key == ConsoleKey.UpArrow) direction = Direction.UP;
            else if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
        }


        private Point GetNextPoint()
        {
            Point p = new Point(pList.Last());
            p.Move(1, direction);
            return p;
        }

        internal bool Eat(Food food)
        {
            Point head = GetNextPoint();
            if (head.Collide(food.food))
            {
                food.food.sym = head.sym; 
                pList.Add(food.food);
                this.Draw();
                return true;
            }
            else return false;
        }

        public bool Collide(List<Point> wall)
        {
            Point head = GetNextPoint();
            for (int i = 0; i < pList.Count - 1; i++)
            {
                if (head.Collide(pList[i])) return false;
            }
            if (head.Collide(wall)) return false;
            return true;
        }
    }
}
