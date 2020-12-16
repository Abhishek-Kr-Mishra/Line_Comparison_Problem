using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProgram
{
    class LineComparison
    {
        public double xAxisStart, yAxisStart, xAxisEnd, yAxisEnd;
        public void AcceptPoints()
        {
            Console.WriteLine("Enter X Start");
            xAxisStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Start");
            yAxisStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X End");
            xAxisEnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y End");
            yAxisEnd = Convert.ToDouble(Console.ReadLine());
        }
       
        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow( (xAxisEnd - xAxisStart),2 ) + Math.Pow( (yAxisEnd-yAxisStart),2 ) );
            return length;
        }
    }
}
