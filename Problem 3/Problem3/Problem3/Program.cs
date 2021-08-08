using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparison3 Length1 = new LineComparison3();
            Console.Write("Enter The Value of X1: ");
            Length1.X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of X2: ");
            Length1.X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of X3: ");
            Length1.X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of X4: ");
            Length1.X4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y1: ");
            Length1.Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y2: ");
            Length1.Y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y3: ");
            Length1.Y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y4: ");
            Length1.Y4 = Convert.ToInt32(Console.ReadLine());
            Length1.L1 = Math.Sqrt(Math.Pow(Length1.X2 - Length1.X1, 2) + Math.Pow(Length1.Y2 - Length1.Y1, 2));
            Console.WriteLine("Length of Line L1 is " + Length1.L1);
            Length1.L2 = Math.Sqrt(Math.Pow(Length1.X4 - Length1.X3, 2) + Math.Pow(Length1.Y4 - Length1.Y3, 2));
            Console.WriteLine("Length of Line L2 is " + Length1.L2);
            if (Length1.L2 > Length1.L1)
            {
                Console.WriteLine("The Length Of Line 2 Is Greater Than Length Of Line 1");
            }
            else if (Length1.L2 < Length1.L1)
            {
                Console.WriteLine("The Length Of Line 2 Is Less Than Length Of Line 1");
            }
            else
            {
                Console.WriteLine("The Length Of Line 2 Is Equal To Length Of Line 1");
            }
        }
    }
}
