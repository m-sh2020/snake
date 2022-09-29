﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeProject
{
    class HorisontalLine : Figure
    {
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //foreach(Point p in pList)
            //{
            //    p.Draw();
            //}
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
