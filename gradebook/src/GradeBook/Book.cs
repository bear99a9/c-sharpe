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
                if(grade == 42.1) 
                {
                    continue;
                }
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }
        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'E':
                    AddGrade(50);
                    break;
                case 'F':
                    AddGrade(40);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
            
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

        public List<double> grades; 
        public string Name; 

    }
}