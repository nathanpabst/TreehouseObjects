using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Invader
    {
        //field to store an instance of the Path object allowing us to update the location and access the info later. call _path in the Invader constructor
        private readonly Path _path;

        //using auto-property. we can remove the private MapLocation _location line because private is the default value
        public MapLocation Location { get; private set; }

        //using _pathStep field, initialized at 0, to keep track of where the invader is along the path
        private int _pathStep = 0;

        //constructor method to set the location on the path
        public Invader(Path path)
        {
            _path = path; 
            Location = _path.GetLocationAt(_pathStep);
        }

        //method to advance invader down the path. public because it needs to be accessable by other classes.
        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }

        //MapLocation needs to be public access modifier so other classes can access the location. We can't use the readonly access modifier because the location will change throughout the game. but public exposes too much of the internal workings of the class--poor encapsulation. Instead we should make the location field private and then write public methods to access the field.
        //_location makes this a private field. The following line is only storing information.
        //private MapLocation _location;

        //using getter method
        //public MapLocation GetLocation()
        //{
        //    return _location;
        //}
        //using setter method..assigning value to the location field
        //public void SetLocation(MapLocation value)
        //{
        //    _location = value;
        //}

        //using property to get and set values..instead of using the methods commented out above
        //public MapLocation Location
        //{
        //    get
        //    {
        //        return _location;
        //    }
        //    //change the setter access level to private to restrict all classes except Invader.cs from setting the value
        //    private set
        //    {
        //        _location = value;
        //    }
        //}


    }
}
