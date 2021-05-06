using Xunit;

namespace GradeBook.Tests
{
    public class NamedObjectTest
    {
        [Fact]
        public void NamedObjectInitializesWithAName()
        {
            var NamedObject = new NamedObject("Sean");

            Assert.Equal("Sean", NamedObject.Name);
        }
    }
}