using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //Using COMPOSITION rather than inheriting from the base class. This allows for more flexibility in altering the class in the future and removes it's dependency on InvaderBase.
    //best practices...minimize the amount of code your class depends upon...rely on interfaces rather than the concrete implementation of classes
    //composition creates a new type by combining one or more other types together. 
    //here we are creating a new invader type that behaves like an invader, but doesn't inherit directly from the InvaderBase class
    class ResurrectingInvader : IInvader
    {
        private BasicInvader _incarnation1;
        private StrongInvader _incarnation2;

        //ResurrectingInvader implements the IInvader interface so we must also implement (see => below) all the members of the interface. 
        //all members of an interface must be public
        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;

        public int Health => _incarnation1.IsNeutralized ? _incarnation2.Health : _incarnation1.Health;

        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);

        //constructor creating the two invaders that compose the ResurrectingInvader class
        public ResurrectingInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
        }

        //IInvader inherits from the IMoveable & IMappable interfaces, so they must also be included in this class
        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }

        public void DecreaseHealth(int factor)
        {
            if (!_incarnation1.IsNeutralized)
            {
                _incarnation1.DecreaseHealth(factor);
            }
            else
            {
                _incarnation2.DecreaseHealth(factor);
            }
        }

    }
}
