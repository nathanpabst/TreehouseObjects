using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                //returns true if the objects contain the same value. overriding EQUALS in the Point class because we don't want to check that if the objects are the exact same...just that they refer to the same coordinates on the map.
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
