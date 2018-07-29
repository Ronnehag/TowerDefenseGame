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

        public override string ToString()
        {
            return X + "," + Y;
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Point)) // This also checks if it's null
            {
                return false;
            }
            Point that = obj as Point;
            return X == that.X && Y == that.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() *31 + Y.GetHashCode();
        }


    }
}
