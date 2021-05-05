using System.Collections.Generic;
using System;

namespace GradeBook 
{
    
    public class Book
    {   
        public Book(string name) 
        {
            grades = new List<double>();
            Name = name; 
        }

        public Statistics GetStatistics() {
            
            var result = new Statistics();
            result.Average = 0.0;
            grades.Sort();
            result.High = grades[^1];
            result.Low = grades[0];

            foreach (var grade in grades)
            {   
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        public void AddGrade(double grade) 
        {
            grades.Add(grade); 
        }

        private List<double> grades; 
        public string Name; 

    }
}