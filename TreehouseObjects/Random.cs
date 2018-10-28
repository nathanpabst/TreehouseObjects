using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //using System.Random to create a global Random object. This will simplify our code in Tower and ShieldedInvader
    //static classes can't inherit from other classes or be inherited from
    static class Random
    {
            private static System.Random _random = new System.Random();

            public static double NextDouble()
            {
                return _random.NextDouble();
            }
        
    }
}
