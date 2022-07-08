using System;
using my_service.Controllers;
using Xunit;

namespace UnitTest
{
    public class UnitTest_LuckyTickets
    {
        [Fact]
        public void Test1()
        {
            var controller = new OnTheRoadController();
            Int64 result = controller.LuckyTickets(2);

            Assert.True(result == 10);
        }

        [Fact]
        public void Test2()
        {
            var controller = new OnTheRoadController();
            Int64 result = controller.LuckyTickets(4);

            Assert.True(result == 670);
        }

        [Fact]
        public void Test3()
        {
            var controller = new OnTheRoadController();
            Int64 result = controller.LuckyTickets(6);

            Assert.True(result == 55252);
        }

        [Fact]
        public void Test4()
        {
            var controller = new OnTheRoadController();
            Int64 result = controller.LuckyTickets(8);

            Assert.True(result == 4816030);
        }
    }
}
