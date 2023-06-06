using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class LineOPeration
    {
        public void CalculateLength()
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
        }
    }
}
