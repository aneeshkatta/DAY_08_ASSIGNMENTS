using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08LineComparision
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Day08LineComparision
    {
        public class Usercase02LineCompare
        {
            public Double line01Method(Double x1, Double x2, Double y1, Double y2, int i)
            {
                Console.WriteLine("Welcome to Line Comparison Computation Program");
                Console.WriteLine("enter end points of line " + i + " starting point (x1,y1)and ending point (x2,y2) values");
                Console.WriteLine("Entered start  points are" + (x1, y1) + "And Entered End points are" + (x2, y2));
                Double Linelength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("linelength is " + Linelength);

                return +Linelength;
            }


        }
        public class Program2
        {
            public static void Main()
            {
                Usercase02LineCompare ObjClsLine01 = new Usercase02LineCompare();
                Usercase02LineCompare ObjClsLine02 = new Usercase02LineCompare();

                Double line01length;
                line01length = ObjClsLine01.line01Method(20.2, 3.3, 5.5, 9.9, 1);
                Double line02length;
                line02length = ObjClsLine02.line01Method(42.2, 3.3, 5.5, 9.9, 1);

                if (line01length.CompareTo(line02length) == 0)

                {
                    Console.WriteLine("Line01 is equals to line02");
                }
                else if (line01length.CompareTo(line02length) > 0)
                {
                    Console.WriteLine("Line01 is greater than line02");
                }
                else 
                {
                    Console.WriteLine("Line02 is greater than line01");
                }
                

            }
        }

    }
}

