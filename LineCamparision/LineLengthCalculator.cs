using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCamparision
{
    public class LineAndLengthCalculator
    {
        public static void LineLengthcalculator()
        {
            double x1, y1, x2, y2;

            Console.WriteLine("Enter the (x,y) coordinates of the first point:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"The length of the line connecting ({x1},{y1}) and ({x2},{y2}) is {length}");
            LineAndLengthCalculator.LineEqualityChecker( x1,  y1, x2,y2);
        }
        public static void LineEqualityChecker(double x1 , double y1 , double x2, double y2)
        {
            
            if ((x1 == y1 && y2 == x2 ) || (x1 == x2 && y1 == y2 ))
            {
                Console.WriteLine("The two lines are equal.");
            }
            else
            {
                Console.WriteLine("The two lines are not equal.");
            }
        }
    }
}
