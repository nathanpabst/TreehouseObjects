﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //InvaderBase implements the IInvader interface
    //adding the abstract keyword to the class definition states that it is no longer a concrete implementation of the class...it now only provides an abstract definition of what it means to be of a certain class. See BasicInvader file.
    abstract class InvaderBase : IInvader
    {
        //field to store an instance of the Path object allowing us to update the location and access the info later. call _path in the Invader constructor
        private readonly Path _path;
        //using _pathStep field, initialized at 0, to keep track of where the invader is along the path
        private int _pathStep = 0;

        //readonly property initialized to 1
        protected virtual int StepSize { get; } = 1;

        //refactoring the getter into a COMPUTED property to solve for repetition of code in the Invader method and constructor. The property will now update the location for us. 
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        //need to add a Length property in the Path class
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        //setter portion of the property is private with Health being set at 2. other classes should use the DecreaseHealth method below
        //adding abstract here ensures that the Health property must be overridden in each sub-class
        public abstract int Health { get; protected set; }

        //property returns true if the invaders health drops to zero
        public bool IsNeutralized => Health <= 0;

        //property returns true if the invader has not been neutralized or has scored
        public bool IsActive => !(IsNeutralized || HasScored);

        //constructor method to set the location on the path
        public InvaderBase(Path path)
        {
            _path = path;
        }

        //method to advance invader down the path. public because it needs to be accessable by other classes.
        public virtual void Move() => _pathStep += StepSize;

        //method to decrease invader health when necessary. public because it needs to be accessable by other classes.
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot and hit an invader!");
        }


    }
}
