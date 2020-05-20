using System;
using System.Collections.Generic;
using System.Text;

namespace Snake2
{
    class Wall : Figure
    {
        public Wall(int width, int height)
        {
            pList = new List<Point>();
            new Wall('h', 1, 1, width - 1, '_', ref pList);
            new Wall('h', 1, height-1, width - 1, '-', ref pList);
            new Wall('v', 1, 1, height - 3, '|', ref pList);
            new Wall('v', width-1, 1, height - 3, '|', ref pList);
            Draw();
        }

        public Wall(char type, int x, int y, int length, char sym, ref List<Point> p)
        {
            for (int i = 0; i < length; i++) p.Add(type == 'h' ? new Point(x + i, y, sym) : new Point(x, y + i, sym));
        }
    }
}
