using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class FastInvader : Invader
    {
        protected override int StepSize { get; } = 2;

        public FastInvader(Path path) : base (path)
        {}



    }
}
