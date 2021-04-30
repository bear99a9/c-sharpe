using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {   
            var book = new Book(" ");
            book.Add(89.1);
            book.Add(90.5);
            book.Add(77.3);
            
            
        }
    }
}
