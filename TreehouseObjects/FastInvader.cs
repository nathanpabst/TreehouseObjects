using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{

    class FastInvader : InvaderBase
    {
        protected override int StepSize { get; } = 2;

        public override int Health { get; protected set; } = 2;


        public FastInvader(Path path) : base(path)
        {

        }

    }
}
