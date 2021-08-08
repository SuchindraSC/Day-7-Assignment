using System;

namespace Problem_1
{
     public class LineComparison
    {
            static int x1 = Convert.ToInt32(Console.ReadLine());
            static int x2 = Convert.ToInt32(Console.ReadLine());
            static int y1 = Convert.ToInt32(Console.ReadLine());
            static int y2 = Convert.ToInt32(Console.ReadLine());
            public double LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    }
}
