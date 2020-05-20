using System;
using System.Collections.Generic;
using System.Text;

namespace Snake2
{
    class Figure
    {
        public List<Point> pList;

        public void Draw()
        {
            foreach (var w in pList)
            {
                w.Draw();
            }
        }

    }
}
