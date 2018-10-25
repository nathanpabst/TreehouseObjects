using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 3;

        public LongRangeTower(MapLocation location) :base(location)
        {

        }
    }
}
