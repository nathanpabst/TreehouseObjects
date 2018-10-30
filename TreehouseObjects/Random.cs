using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    //using System.Random to create a global Random object. This will simplify our code in Tower and ShieldedInvader
    //static classes are globally accessible. They can't be instantiated, inherit from other classes or be inherited
    //best practice..create static classes where the members of the class are immutable. 
    static class Random
    {
            private static System.Random _random = new System.Random();

            public static double NextDouble()
            {
                return _random.NextDouble();
            }
        
    }
}
