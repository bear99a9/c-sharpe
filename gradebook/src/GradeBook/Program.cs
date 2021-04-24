﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var numbers = new[] {12.7, 10.3, 6.11, 4.11};
            var result = numbers[0] + numbers[1] + numbers[2];
            result += numbers[3];
            Console.WriteLine(result);
            
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
