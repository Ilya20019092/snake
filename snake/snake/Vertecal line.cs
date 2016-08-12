using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class vert : Class1

    {
        public vert(int yLeft, int yRight, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

       
            }

        }
    }
}
