using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    public class MapLocation : Point
    {
        //constructor
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            //using the OnMap method to determine if the map location being constructed is on the map 
            if (!map.OnMap(this))
            {
                //if the given map location is not on the map, throw an exception
                throw new OutOfBoundsException(this + " is outside the boundaries of the map");
            }
        }

        //use distanceTo method to determine distance between the map location and range that is passed in
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
