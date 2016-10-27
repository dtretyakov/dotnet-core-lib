using Xunit;

namespace TestLibrary
{
    public class TestClass
    {
        [Fact]
        public void SayHello()
        {
            Assert.True(false, "My error message");
        }
    }
}


