using System;
using my_service.Controllers;
using Xunit;

namespace UnitTest
{
    public class UnitTest_TrickyCalculator
    {
        [Fact]
        public void Test1()
        {
            var controller = new OnTheRoadController();
            int result = controller.TrickyCalculator(2, 3);

            Assert.True(result == 6);
        }

        [Fact]
        public void Test2()
        {
            var controller = new OnTheRoadController();
            int result = controller.TrickyCalculator(-2, -3);

            Assert.True(result == 6);
        }

        [Fact]
        public void Test3()
        {
            var controller = new OnTheRoadController();
            int result = controller.TrickyCalculator(50, 20);

            Assert.True(result == 1000);
        }

        [Fact]
        public void Test4()
        {
            var controller = new OnTheRoadController();
            int result = controller.TrickyCalculator(-9, 20);

            Assert.True(result == -180);
        }
    }
}
