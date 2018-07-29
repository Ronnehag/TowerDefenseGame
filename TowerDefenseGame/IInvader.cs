using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMoveable
    {
        void Move();
    }

    interface IInvader : IMappable, IMoveable
    {
       
        int Health { get; }

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);
    }
}
    


