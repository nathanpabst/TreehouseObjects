using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Invader
    {
        //field to store an instance of the Path object allowing us to update the location and access the info later. call _path in the Invader constructor
        private readonly Path _path;

        //refactoring the getter into a COMPUTED property to solve for repetition of code in the Invader method and constructor. The property will now update the location for us. 
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }

        }

        //using _pathStep field, initialized at 0, to keep track of where the invader is along the path
        private int _pathStep = 0;

        //constructor method to set the location on the path
        public Invader(Path path)
        {
            _path = path;
        }

        //method to advance invader down the path. public because it needs to be accessable by other classes.
        public void Move()
        {
            _pathStep += 1;
        }

    }
}
