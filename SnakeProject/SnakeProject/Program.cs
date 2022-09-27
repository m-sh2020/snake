﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80,25);

            //Отрисовка рамочки
            HorisontalLine upLine = new HorisontalLine(0, 78, 0,'+') ;
            HorisontalLine downLine = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
           

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            Console.ReadLine();
        }
    }
}
