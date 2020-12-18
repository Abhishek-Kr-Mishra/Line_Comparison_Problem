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

            bool lengthStauts = LengthComparisonUsingEqualsMethod(firstLineLength, secondLineLength);
            if (lengthStauts)
            {
                Console.WriteLine("Both the lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
            int status = LengthComparisonUsingCompareTo(firstLineLength, secondLineLength);
            switch (status)
            {
                case 0:
                    Console.WriteLine("Length of Both the Line is Equal");
                    break;
                case 1:
                    Console.WriteLine("Length of First Line is Greater");
                    break;
                default:
                    Console.WriteLine("Length of Second Line is Greater");
                    break;
            }
        }
        public static int LengthComparisonUsingCompareTo(double firstLength, double secondLength)
            {
                return firstLength.CompareTo(secondLength);
            }
        public static Boolean LengthComparisonUsingEqualsMethod(double firstLength, double secondLength)
        {
            return firstLength.Equals(secondLength);
        }
    }
}
