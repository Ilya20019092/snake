using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Snake;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {



            HorizLine line1 = new HorizLine(0, 78, 0, '-');
            line1.Drow();

            vert line2 = new vert(0, 24, 0, ':');
            line2.Drow();

            HorizLine line3 = new HorizLine(0, 78, 24, '-');
            line3.Drow();

            vert line4 = new vert(0, 24, 78, ':');
            line4.Drow();





            Console.ReadLine();



               




















        }
    }
}
