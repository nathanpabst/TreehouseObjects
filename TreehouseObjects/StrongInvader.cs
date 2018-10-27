﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class StrongInvader : InvaderBase
    {
        public override int Health { get; protected set; } = 2;

        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
