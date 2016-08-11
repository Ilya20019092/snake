using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {























    
List<int> li1 = new List<int>();
            for (int i = 0; i < 100; i += 5)
            {
                li1.Add(i);
            }
            foreach (int i in li1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            int x = li1[0];
            int y = li1[1];
            int z = li1[2];
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();
            li1.RemoveAt(0);
            li1.RemoveAt(4);
            li1.RemoveAt(9);
            li1.RemoveAt(14);
            Console.ReadLine();
            foreach (int i in li1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();























        }
    }
}
