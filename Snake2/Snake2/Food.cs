using System;
using System.Collections.Generic;
using System.Text;

namespace Snake2
{
    class Food
    {
        int widht, heigth;
        char sym;
        public Point food;
        List<Point> snake;
        bool c = true;
        Random random = new Random();

        public Food(int w, int h, char s, Snake _snake)
        {
            widht = w;
            heigth = h;
            sym = s;
            snake = _snake.pList;
        }

        public void Create()
        {
            food = new Point(random.Next(3, widht - 4), random.Next(3, heigth - 4), sym);
            foreach(Point p in snake)
            {
                if (food.x == p.x && food.y == p.y)
                {
                    c = false;
                    break;
                }
                else c = true;
            }
            if (c) food.Draw();
            else Create();
        }
    }
}
