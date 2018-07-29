using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    interface IInvader
    {
        MapLocation Location { get; }

        int Health { get; }

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);
    }
}
    


