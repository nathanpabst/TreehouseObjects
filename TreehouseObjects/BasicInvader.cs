using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //this is the concrete implementation of the BasicInvader type
    class BasicInvader : InvaderBase
    {
        //because we changed the Health property in InvaderBase to abstract, we must instantiate the property in each invader type.
        public override int Health { get; protected set; } = 2;

        public BasicInvader(Path path) : base(path)
        {

        }

    }
}
