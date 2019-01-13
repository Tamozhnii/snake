﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int Up_y, int Down_y, char sym)
        {
            for (int y = Up_y; y <= Down_y; y++)
            {
                Point p = new Point(x, y, sym);
                PList.Add(p);
            }
        }
        
    }
}
