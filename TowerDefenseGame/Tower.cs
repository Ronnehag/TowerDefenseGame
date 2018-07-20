using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Tower
    {
        private readonly MapLocation _mapLocation;

        public Tower(MapLocation location, Path path)
        {
            for (int i = 0; i < path.Length; i++)
            {
                MapLocation pathToCheck = path.GetLocationAt(i);

                if(location.X == pathToCheck.X && location.Y == pathToCheck.Y)
                {
                    throw new OutOfBoundsException("Towers can't be placed on a path");
                }
            }
            _mapLocation = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {

            foreach(var invader in invaders)
            {
               
                if (invader.IsActive && _mapLocation.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }

        }


    }
}
