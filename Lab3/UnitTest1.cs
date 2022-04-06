using Xunit;
using DataServices;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal((DataService.GetDay("05.04.2022")), (int)2);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal((DataService.GetDay("01.01.2020")), (int)3);
        }
    }
}