using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        
        public int DistanceTo(int x, int y)
        {
            // Using Distance Formula
            // Distance Formula: Given the two points (x1, y1) and (x2, y2), 
            // the distance d between these points is given by the formula.
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

        }
    }
}
