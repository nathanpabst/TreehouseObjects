using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        //constructor method to initialize the fields with values
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        

        //method
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width && 
                   point.Y >= 0 && point.Y   < Height;
        }
    }
}
