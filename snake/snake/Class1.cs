using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    internal class Class1
    {
        protected List<Point> plist;

        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
