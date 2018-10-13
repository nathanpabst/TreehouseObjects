using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Tower
    {
        //use the following const variables to make code more readable
        private const int _range = 1;
        private const int _power = 1;

        //field to determine tower location on the map
        private readonly MapLocation _location;

        //constructor passing in location as a parameter and setting the location field
        public Tower(MapLocation location)
        {
            _location = location;
        }

        //Loop through each index in the array, increment by one, and store in variable
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }



    }
}
