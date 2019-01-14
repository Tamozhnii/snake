using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int Lenght, direction Direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < Lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                pList.Add(p);
            }
        }
    }
}
