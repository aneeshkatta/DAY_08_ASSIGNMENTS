using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day08LineComparision
{
    public class UC01Linelength
    {
        public void linecompareMethod(Double x1, Double x2, Double y1, Double y2)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("enter end points of line 01 starting point (x1,y1)and ending point (x2,y2) values");
            Console.WriteLine("Entered start  points are" + (x1, y1) + "And Entered End points are" + (x2, y2));
            Double Linelength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("linelength is " + Linelength);

        }

    }
    public class Program1
    {
        public static void Main(string[] args)
        {
            UC01Linelength prob01 = new UC01Linelength();

            prob01.linecompareMethod(2.2, 3.3, 5.5, 9.9);

        }
    }
}

