using System.Collections.Generic;
using System;

namespace GradeBook 
{
    
    public class Book
    {   
        public Book(string name) 
        {
            grades = new List<double>();
            this.name = name; 
        }

        public void ShowStats() {
            HighGrade();
            LowGrade();
            AverageGrade(); 
        }

        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        } 

        private void HighGrade()
        {
            grades.Sort();
            var high = grades[^1];
            Console.WriteLine($"The highest grade is {high}");
        }

        private void LowGrade()
        {
            grades.Sort();
            var low = grades[0];
            Console.WriteLine($"The lowest grade is {low}");
        }

        private void AverageGrade() 
        {
            var result = 0.0;

            foreach (var number in grades)
            {   
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }

        private List<double> grades; 
        private string name; 

    }
}