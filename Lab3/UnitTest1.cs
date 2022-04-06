using Xunit;
using CompareVal;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 0;
            int b = 0;
            Assert.Equal(0, Compare.minv(a, b));
        }

        [Fact]
        public void Test2()
        {
            int a = 1;
            int b = 2;
            Assert.Equal(1, Compare.minv(a, b));
        }

        [Fact]
        public void Test3()
        {
            int a = 101;
            int b = 94;
            Assert.Equal(94, Compare.minv(a, b));
        }
    }
}