using System;
using System.Collections.Generic;

namespace GradeBook 
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new Book("Sean's grade book");
            
            while (true)
            {
                Console.WriteLine($"Please input the grade. Enter q to exit and see results.");
                
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                
            }
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The average letter grade is {stats.Letter}");
            
        }
    }
}


