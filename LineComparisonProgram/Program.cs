using System;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To Line Comparison Program");
            LineComparison firstLine = new LineComparison();
            LineComparison secondLine = new LineComparison();

            firstLine.AcceptPoints();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + firstLineLength);

            secondLine.AcceptPoints();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line according to points is= " + secondLineLength);

            int status = LengthComparison(firstLineLength, secondLineLength);
            if (status > 0)
            {
                Console.WriteLine("Length Of First Line is greater ");
            }
            else if(status < 0)
            {
                Console.WriteLine("Length Of Second Line is greater");
            }
            else
            {
                Console.WriteLine("Length of both Lines are Equal");
            }
        }
        public static int LengthComparison(double firstLength, double secondLength)
            {
                return firstLength.CompareTo(secondLength);
            } 
    }
}
