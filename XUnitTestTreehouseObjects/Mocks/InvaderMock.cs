using System;
using System.Collections.Generic;
using System.Text;
using TreehouseObjects;

namespace XUnitTestTreehouseObjects.Tests.Mocks
{
    class InvaderMock : IInvader
    {
        public bool HasScored => false;

        public int Health { get; private set; } = 2;

        public bool IsActive => true;

        public bool IsNeutralized => false;

        public MapLocation Location { get; set; }

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
