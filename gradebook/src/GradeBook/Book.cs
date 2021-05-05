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
            
            var index = 0;
            do
            {
                result.Average += grades[index];
                index += 1;
            } while (index < grades.Count);

            result.Average /= grades.Count;

            return result;
        }

        public void AddGrade(double grade) 
        {   
            if (grade <= 100 && grade >= 0)
            {   
                grades.Add(grade); 
            }
            else
            {
                Console.WriteLine($"{grade} is an invalid number");
            }
        }

        private List<double> grades; 
        public string Name; 

    }
}