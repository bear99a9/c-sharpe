using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {   
            var book = new Book(" ");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.GetStatistics();
            

            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter); 
            
        }

        [Fact]

        public void AddGradeTest() 
        {
            var book = new Book("Sean");
            book.AddGrade(105.6);

            Assert.Equal(0, book.grades.Count);
        }

        [Fact]

        public void AddLetterGradeTest()
        {
            var book = new Book("Sean");
            book.AddLetterGrade('A');
            book.AddLetterGrade('B');
            book.AddLetterGrade('C');
            book.AddLetterGrade('D');
            book.AddLetterGrade('Z');

            Assert.Equal(90, book.grades[0]);
            Assert.Equal(80, book.grades[1]);
            Assert.Equal(70, book.grades[2]);
            Assert.Equal(60, book.grades[3]);
            Assert.Equal(0, book.grades[4]);
        }

    }
}
