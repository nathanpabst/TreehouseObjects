using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //interfaces can only declare the public members that subclasses must have. the point is to only expose what is needed by the code that is using the class
    //classes can only inherit directly from one other class. interface solves for multiple inheritance. a class can implement as many interfaces as needed.
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();

    }
    //the interface defines what the properties and methods are and what their parameter and return types are. 
    //methods and properties in an Interface do not have implementation. Interfaces only define public members..so we can delete that term for each. virtual and abstract modifiers are also not needed in Interfaces.
    interface IInvader : IMappable, IMovable
    {

        bool HasScored { get; }

        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);

    }
}
