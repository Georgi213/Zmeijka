﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeijka
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');

            p1.Draw();


            Point p2 = new Point(4, 5, '#');

            p2.Draw();

            Point p3 = new Point(6, 2, '$');

            p3.Draw();

            Point p4 = new Point(2, 7, '!');

            p4.Draw();

            Point p5 = new Point(5, 1, '/');

            p5.Draw();

            Point p6 = new Point(3, 9, '[');

            p6.Draw();

            HorizontallLine line = new HorizontallLine(5, 10, 8, '+');
            line.Drow();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)

            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);


            Console.ReadLine();
        }

    }
}
