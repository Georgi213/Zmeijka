using System.Collections.Generic;
using Zmeijka;

namespace Snake
{
    internal class Figure
    {
        class HorizontallLine
        {
            List<Point> pList;
            public HorizontallLine(int xleft, int xright, int y, char sym)
            {
                pList = new List<Point>();
                for (int x = xleft; x <= xright; x++)
                {
                    Point p = new Point(x, y, sym);
                    pList.Add(p);
                }
            }
        }
    }
}




