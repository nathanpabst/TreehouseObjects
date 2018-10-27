﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class ShieldedInvader : InvaderBase
    {
        private static Random _random = new Random();
        public override int Health { get; protected set; } = 2;


        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a shielded invader, but it sustained no damage.");
            }
        }

    }
}
