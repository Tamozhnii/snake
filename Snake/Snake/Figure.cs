using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        private List<Point> pList;

        internal List<Point> PList
        {
            get => pList; set => pList = value;
        }

        public void Drow()
        {
            foreach (Point p in PList)
            {
                p.Drow();
            }
        }
    }
}
