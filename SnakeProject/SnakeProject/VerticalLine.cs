using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeProject
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yButton, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yTop; y <= yButton; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

    }
}
