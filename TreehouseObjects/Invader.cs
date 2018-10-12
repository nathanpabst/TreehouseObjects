using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Invader
    {
        //using auto-property. we can remove the private MapLocation _location line because private is the default value
        public MapLocation Location { get; private set; }

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
