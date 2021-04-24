using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var numbers = new[] {12.7, 10.3, 6.11, 4.11};

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.11};
            grades.Add(56.1);
            var result = 0.0;

            foreach (var number in grades)
            {
                result += number;
            }
            var average = result / grades.Count;
            Console.WriteLine(average);
            
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
