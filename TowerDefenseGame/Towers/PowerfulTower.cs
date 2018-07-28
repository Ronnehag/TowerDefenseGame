using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class PowerfulTower : Tower
    {
        protected override int TurretPower { get; } = 2;

        public PowerfulTower(MapLocation location) : base (location)
        { }
    }
}
