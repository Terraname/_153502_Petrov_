using Xunit;
//using Company;
using Company;

namespace Test1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Tariph tar = new Tariph(10, 20, "smth");
            Assert.Equal(200, tar.GetTotalPrice(), 3);
        }

        [Fact]
        public void Test2()
        {
            Tariph tar = new Tariph(15, 24, "smth");
            Assert.Equal(360, tar.GetTotalPrice(), 3);
        }

        [Fact]
        public void Test3()
        {
            Tariph tar1 = new Tariph(10, 20, "smth");
            Tariph tar2 = new Tariph(15, 24, "smth");
            TransportCompany.getInstance("smth", 12.5);
            TransportCompany.AddTariph(tar1);
            TransportCompany.AddTariph(tar2);
            Assert.Equal(560, TransportCompany.GetTotalIncome(), 3);
            TransportCompany.getInstance("", 0).ClearInstance();
        }

        [Fact]
        public void Test4()
        {
            Tariph tar1 = new Tariph(10, 20, "smth");
            Tariph tar2 = new Tariph(15, 24, "smth");
            TransportCompany.getInstance("smth", 12.5);
            TransportCompany.AddTariph(20, 10);
            TransportCompany.AddTariph(40);
            Assert.Equal(700, TransportCompany.GetTotalIncome(), 3);
            TransportCompany.getInstance("", 0).ClearInstance();
        }
    }
}