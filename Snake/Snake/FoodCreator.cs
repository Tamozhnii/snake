﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHieght;
        char sym;

        Random random = new Random( );

        public FoodCreator(int mapWidth, int mapHieght, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHieght = mapHieght;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHieght - 2);
            return new Point(x, y, sym);
        }
    }
}
