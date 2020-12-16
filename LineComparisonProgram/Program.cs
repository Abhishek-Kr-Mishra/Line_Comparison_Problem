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

            bool status = LengthComparison(firstLineLength, secondLineLength);
            if (status)
            {
                Console.WriteLine("Both the lengths are Equal");
            }
            else
            {
                Console.WriteLine("Lengths are not Equal");
            }
        }

        public static Boolean LengthComparison(double firstLength, double secondLength)
        {
            return firstLength.Equals(secondLength);
        } 
    }
}
