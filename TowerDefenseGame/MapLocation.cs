﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base (x, y)
        {
            if(!map.OnMap(this)) // If the constructed location is outside the map.
            {
                throw new OutOfBoundsException(this + "is outside the boundaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }

    }
}
