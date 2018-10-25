using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Tower
    {
        //use the following const variables to make code more readable
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        //field to determine tower location on the map
        private readonly MapLocation _location;

        //constructor passing in location as a parameter and setting the location field
        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        //Loop through each index in the array, increment by one, and store in variable
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                    invader.DecreaseHealth(Power);
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("he dead.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You missed!");
                    }
                    break;
                }
            }
        }



    }
}
