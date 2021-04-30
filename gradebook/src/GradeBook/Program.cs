using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new Book("Sean's grade book");
            book.AddGrade(89.1);
            book.AddGrade(93.1);
            book.AddGrade(9.7);


            var grades = new List<double>() {12.7, 10.3, 6.11, 4.11};
            grades.Add(56.1);
            grades.Sort();
            var low = grades[0]; 
            grades.Reverse();
            var high = grades[0];
            

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue; 

            foreach (var number in grades)
            {   
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade); 
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            if (high == highGrade) 
            {
                Console.WriteLine($"The highest grade is {high}");
            }
            if (low == lowGrade) 
            {
                Console.WriteLine($"The lowest grade is {low}");

            }

        }
    }
}


