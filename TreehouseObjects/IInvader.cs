using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //the interface defines what the properties and methods are and what their parameter and return types are. 
    //methods and properties in an Interface do not have implementation. Interfaces only define public members..so we can delete that term for each. virtual and abstract modifiers are also not needed in Interfaces.
    interface IInvader
    {

        MapLocation Location { get; }

        bool HasScored { get; }

        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);


    }
}
