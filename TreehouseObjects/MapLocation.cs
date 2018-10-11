﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class MapLocation : Point
    {
        //constructor
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            //using the OnMap method to determine if the map location being constructed is on the map 
            if (!map.OnMap(this))
            {
                //if the given map location is not on the map, throw an exception
                throw new Exception($"{x}, {y} is outside the boundaries of the map");
            }
        }
    }
}
