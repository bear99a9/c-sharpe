using System.Collections.Generic;
using System;

namespace GradeBook 
{   
    public delegate void GradeAddedDelegate(object sender, EventArgs args); 

    public class InMemoryBook : Book
    {   
        public InMemoryBook(string name) : base(name)
        {   
            grades = new List<double>();
            Name = name; 
        }

        public override Statistics GetStatistics() {
            
            var result = new Statistics();
            
            for (var i = 0; i < grades.Count; i++)
            {
                result.Add(grades[i]);
            }
            
            return result;
        }
        public override void AddGrade(double grade) 
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

        public override event GradeAddedDelegate GradeAdded;

        private List<double> grades; 
        
        public const string CATEGORY = "Science";
        // const cannot be overwritten anywhere 
        // public allows the const to be read from outside the class
    }
}