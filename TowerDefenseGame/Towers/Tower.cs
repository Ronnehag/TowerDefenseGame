using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Tower
    {
        protected virtual int TurretRange { get; } = 1;
        protected virtual int TurretPower { get; } = 1;
        protected virtual double Accuracy { get; } = 0.75;
    

        private readonly MapLocation _location;

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
            return Random.NextDouble() < Accuracy;
        }


        public void FireOnInvaders(IInvader[] invaders)
        {

            foreach(IInvader invader in invaders)
            {
               
                if (invader.IsActive && _location.InRangeOf(invader.Location, TurretRange))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(TurretPower);
                        Console.WriteLine("Tower shot hit!");

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Targeted invader is neutralized at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tower shot missed the invader.");
                    }

                }
            }

        }
        

    }
}
