using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparison2 Length = new LineComparison2();
            Console.Write("Enter The Value of X1: ");
            Length.X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of X2: ");
            Length.X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of X3: ");
            Length.X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of X4: ");
            Length.X4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y1: ");
            Length.Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y2: ");
            Length.Y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y3: ");
            Length.Y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of Y4: ");
            Length.Y4 = Convert.ToInt32(Console.ReadLine());
            Length.L1 = Math.Sqrt(Math.Pow(Length.X2 - Length.X1, 2) + Math.Pow(Length.Y2 - Length.Y1, 2));
            Console.WriteLine("Length of Line L1 is "+Length.L1);
            Length.L2 = Math.Sqrt(Math.Pow(Length.X4 - Length.X3, 2) + Math.Pow(Length.Y4 - Length.Y3, 2));
            Console.WriteLine("Length of Line L2 is "+Length.L2);
            if (Length.L1 == Length.L2)
            {
                Console.WriteLine("Both The Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Both The Lines Are UnEqual");
            }
        }
    }
}
