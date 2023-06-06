using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class LineOPeration
    {
        public double CalculateLength()
        {
            Console.WriteLine("Enter x1 values");
            double x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 values");
            double x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 values");
            double y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 values");
            double y2=Convert.ToInt32(Console.ReadLine());
            double length=Math.Sqrt((Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
            Console.WriteLine("Length of Line is : {0}",length);
            return length;
        }
        public void CheckEqualityOfLine(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Both Lines are Equal");
            else
                Console.WriteLine("Lines are Not Equal");
        }
        public void CompareTwoLines(double line1, double line2)
        {
            if(line1.CompareTo(line2) < 0)
                Console.WriteLine("Line2 is Greater Than Line1");
            else if(line1.CompareTo(line2) > 0)
                Console.WriteLine("Line2 is Less Than Line1");
            else
                Console.WriteLine("Both Lines are Equal");
        }
    }
}
