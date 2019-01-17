using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {

        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine UpLine = new HorizontalLine(0, mapWidth - 2, 0, '-');
            HorizontalLine DownLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '-');
            VerticalLine LeftLine = new VerticalLine(0, mapHeight - 1, 0, '|');
            VerticalLine RightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '|');

            wallList.Add(UpLine);
            wallList.Add(DownLine);
            wallList.Add(LeftLine);
            wallList.Add(RightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure)) {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
        
    }
}
