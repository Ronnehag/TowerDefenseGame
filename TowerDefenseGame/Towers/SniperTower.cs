using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 1.0;

        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
