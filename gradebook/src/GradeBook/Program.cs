using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var x = 34.1;
            var y = 2.56;
            var result = y + x;
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
