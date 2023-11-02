using Xunit;

namespace XTestTemplate
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var s = 2 + 4;

            Assert.Equal(6, s);
        }
    }
}