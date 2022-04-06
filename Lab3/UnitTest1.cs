using Xunit;
using Myclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(Class1.func(0, 0), Math.Cos(1));
        }
    }
}