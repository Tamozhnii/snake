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
            pList = new List<Point>();
            for (int x = Left_x; x <= Right_x; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
                        
        }

    }
}
