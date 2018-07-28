using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class LongRangeTower : Tower
    {
        protected override int TurretRange { get; } = 2;

        public LongRangeTower(MapLocation location) : base (location)
        { }
    }
}
