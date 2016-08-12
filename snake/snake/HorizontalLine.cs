using System;
using System.Collections.Generic;
using snake;

namespace Snake
{

    class HorizLine: Class1
    {
        public HorizLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

            }
        }
    }
}