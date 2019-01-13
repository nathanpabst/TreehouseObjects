using System;
using Xunit;
using System.Threading.Tasks;
using TreehouseObjects;

namespace XUnitTestTreehouseObjects.Tests
{
    public class PointTests
    {
        [Fact]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact]
        public void DistanceToTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}
