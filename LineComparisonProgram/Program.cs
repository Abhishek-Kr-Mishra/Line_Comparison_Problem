using System;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To Line Comparison Program");
            LineComparison lineComparison = new LineComparison();

            lineComparison.AcceptPoints();
            double lineLength = lineComparison.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + lineLength);
        }
    }
}
