namespace LineComparisionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LineOPeration lineOPeration = new LineOPeration();
            Console.WriteLine("Calculating length of Line1");
            double line1=lineOPeration.CalculateLength();
            Console.WriteLine("Calculating length of Line2");
            double line2=lineOPeration.CalculateLength();
            //lineOPeration.CheckEqualityOfLine(line1,line2);
            lineOPeration.CompareTwoLines(line1,line2);
        }
    }
}