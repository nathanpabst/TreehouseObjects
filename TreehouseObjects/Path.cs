﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Path
    {
        private readonly MapLocation[] _path;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }  

    }
}
