﻿using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Threading;
using Snake;

namespace snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            HorizLine line1 = new HorizLine(0, 78, 0, '-');
            line1.Drow();
            vert line2 = new vert(0, 24, 0, ':');
            line2.Drow();
            HorizLine line3 = new HorizLine(0, 78, 24, '-');
            line3.Drow();
            vert line4 = new vert(0, 24, 78, ':');
            line4.Drow();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();



            }

        }
    }
}
