using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Map
    {
        // Can't change values after constructed
        public readonly int width;
        public readonly int height;

        public Map(int _width, int _height)
        {
            width = _width;
            height = _height;
        }

    }
}
