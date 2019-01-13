using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        
        public HorizontalLine(int Left_x, int Right_x, int y, char sym)
        {
            for (int x = Left_x; x <= Right_x; x++)
            {
                Point p = new Point(x, y, sym);
                PList.Add(p);
            }
        }

    }
}
