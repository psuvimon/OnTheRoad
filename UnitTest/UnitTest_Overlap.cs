using System;
using my_service.Controllers;
using Xunit;

namespace UnitTest
{
    public class UnitTest_Overlap
    {
        [Fact]
        public void Test1()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 01:00:00,2019-04-09 02:00:00"
                                            , "2019-04-09 01:30:00,2019-04-09 02:30:00");

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 01:00:00,2019-04-09 02:00:00"
                                            , "2019-04-09 02:00:00,2019-04-09 02:30:00");

            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 04:00:00,2019-04-09 05:00:00"
                                            , "2019-04-09 01:00:00,2019-04-09 04:30:00");

            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 02:00:00,2019-04-09 03:00:00"
                                            , "2019-04-09 01:00:00,2019-04-09 04:30:00");

            Assert.True(result);
        }

        [Fact]
        public void Test5()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 01:00:00,2019-04-09 05:00:00"
                                            , "2019-04-09 01:30:00,2019-04-09 04:30:00");

            Assert.True(result);
        }

        [Fact]
        public void Test6()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 01:00:00,2019-04-09 02:00:00"
                                            , "2019-04-09 02:00:00,2019-04-09 03:00:00");

            Assert.True(result);
        }

        [Fact]
        public void Test7()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 01:00:00,2019-04-09 02:00:00"
                                            , "2019-04-09 02:00:01,2019-04-09 02:30:00");

            Assert.False(result);
        }

        [Fact]
        public void Test8()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 03:00:00,2019-04-09 04:00:00"
                                            , "2019-04-09 02:00:00,2019-04-09 02:59:59");

            Assert.False(result);
        }

        [Fact]
        public void Test9()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("0001-04-09 01:00:00,0001-04-09 02:00:00"
                                            , "0001-04-09 01:30:00,0001-04-09 02:30:00");

            Assert.True(result);
        }

        [Fact]
        public void Test10()
        {
            var controller = new OnTheRoadController();
            bool result = controller.Overlap("2019-04-09 01:00:00,2019-04-09 02:00:00"
                                            , "2019-04-09 01:00:00,2019-04-09 02:00:00");

            Assert.True(result);
        }
    }
}
