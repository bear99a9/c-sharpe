using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string LogMessage);
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");

            Assert.Equal(3, count);
        }
        string IncrementCount(string message) {
            count ++;
            return message.ToLower();
        }
        
        string ReturnMessage(string message) {
            count ++;
            return message;
        }

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            string name = "Sean";
            var upper = MakeUppercase(name);

            Assert.Equal("Sean", name);
            Assert.Equal("SEAN", upper);

        }

        private string MakeUppercase(string paramater)
        {
            return paramater.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
            
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }
        [Fact]
        public void CSHARPCanPassByValue()
        {   
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {   
            book = new Book(name);
        }
        
        [Fact]
        public void CSHARPIsPassByValue()
        {   
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {   
            book = new Book(name);
        }

        [Fact]
        public void SetNameFromReference()
        {   
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name; 
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {   
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObjects()
        {   
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }


        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
