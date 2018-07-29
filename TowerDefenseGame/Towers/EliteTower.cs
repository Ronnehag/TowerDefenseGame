using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame.Towers
{
    class EliteTower : Tower
    {
        protected override int TurretRange { get; } = 2;
        protected override int TurretPower { get; } = 2;
        protected override double Accuracy { get; } = 1.0;

        public EliteTower(MapLocation location) : base(location)
        { }

    }
}
