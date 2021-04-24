using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            double x = 34.1;
            double y = 2.56;
            double result = y + x;
            Console.WriteLine($"{result}");

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[1]}!");
            }
            else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
