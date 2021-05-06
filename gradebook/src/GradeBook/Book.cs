using System.Collections.Generic;
using System;

namespace GradeBook 
{   
    public delegate void GradeAddedDelegate(object sender, EventArgs args); 

    public class Book : NamedObject
    {   
        public Book(string name) : base(name)
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

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                case var d when d >= 50.0:
                    result.Letter = 'E';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }
            
            return result;
        }
        public void AddGrade(double grade) 
        {   
            if (grade <= 100 && grade >= 0)
            {   
                grades.Add(grade); 
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public event GradeAddedDelegate GradeAdded;

        private List<double> grades; 
        
        public const string CATEGORY = "Science";
        // const cannot be overwritten anywhere 
        // public allows the const to be read from outside the class
    }
}