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
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Checks if the point coordinates are within the declared maps width/height.
        public bool OnMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width
                            && point.Y >= 0 && point.Y < Height;

            return inBounds;
        }

    }
}
