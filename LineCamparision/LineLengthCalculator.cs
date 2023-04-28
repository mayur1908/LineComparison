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
            Console.WriteLine("Enter the (x,y) coordinates of the first point of line 1:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of line 1:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the first point of line 2:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of line 2:");
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            int comparisonResult = length1.CompareTo(length2);

            if (comparisonResult == 0)
            {
                Console.WriteLine("Line 1 is equal to line 2.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Line 1 is less than line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than line 2.");
            }
        }
    }
}
