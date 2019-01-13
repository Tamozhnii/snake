using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(100, 50);

            HorizontalLine UpLine = new HorizontalLine(0, 99, 0, '%');
            HorizontalLine DownLine = new HorizontalLine(0, 99, 49, '%');
            VerticalLine LeftLine = new VerticalLine(0, 0, 49, '&');
            VerticalLine RightLine = new VerticalLine(99, 0, 49, '&');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p = new Point(7, 9, '*');

            Console.ReadLine();
        }
    }
}
