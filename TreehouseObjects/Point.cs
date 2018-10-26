using System;
using System.Collections.Generic;
using System.Text;


namespace TreehouseObjects
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        //EQUALS method determines if two objects are practically equal. IS will also check to make sure obj is not null  
        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }
            Point that = obj as Point;
            return this.X == that.X && this.Y == that.Y;
        }

        public int DistanceTo(int x, int y)
        {
            //refactored following code into the return statement below
            //int xDiff = X - x;
            //int yDiff = Y - y;

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            //return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        //ex of overloading a method..two methods with the same name taking in different parameters
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
