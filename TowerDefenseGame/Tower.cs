using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _turretRange = 1;
        private const int _turretPower = 1;
        private const double _accuracy = 0.75;

        private static readonly Random _random = new Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

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
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }


        public void FireOnInvaders(Invader[] invaders)
        {

            foreach(var invader in invaders)
            {
               
                if (invader.IsActive && _location.InRangeOf(invader.Location, _turretRange))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_turretPower);
                        Console.WriteLine("Tower shot hit!");

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Targeted invader is neutralized!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tower shot missed the invader!");
                    }

                }
            }

        }
        

    }
}
