using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeProject
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yTop, int yButton, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yTop; y <= yButton; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


            //Point p1 = new Point(4, 4, '*');
            //Point p2 = new Point(5, 4, '*');
            //Point p3 = new Point(6, 4, '*');
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
