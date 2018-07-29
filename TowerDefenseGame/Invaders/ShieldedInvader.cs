using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        // Passes the Path up to to base class Invader
        public ShieldedInvader(Path path) : base(path)
        {}

            public override void DecreaseHealth(int factor)
            {
                if(Random.NextDouble() < .5)
                {
                    base.DecreaseHealth(factor);
                }
                else
                {
                    Console.WriteLine("The invader blocked your shot!");
                }
                
            }
       
        
    }
}
