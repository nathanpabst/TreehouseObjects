using System;
using System.Collections.Generic;
using System.Text;
using TreehouseObjects;
using Xunit;
using XUnitTestTreehouseObjects.Tests.Mocks;

namespace XUnitTestTreehouseObjects.Tests
{
    public class TowerTests
    {

        [Fact()]
        public void FireOnInvadersDecreasesInvadersHealth()
        {
            var map = new Map(3, 3);
            var target = new Tower(new MapLocation(0, 0, map));

            InvaderMock[] invaders = new InvaderMock[]
            {
                new InvaderMock() { Location = new MapLocation(0, 0, map) },
                new InvaderMock() { Location = new MapLocation(0, 0, map) }
            };

            target.FireOnInvaders(invaders);

            Assert.All(invaders, i => Assert.Equal(1, i.Health));
        }
    }
}
