using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TreehouseObjects;
using System.Threading.Tasks;
using System.Linq;

namespace XUnitTestTreehouseObjects.Tests
{
    public class MapLocationTests
    {
        [Fact()]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);
            var exception = Assert.Throws<OutOfBoundsException>(() => new MapLocation(3, 3, map));
        }
    }
}
