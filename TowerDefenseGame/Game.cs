using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            try
            {
                MapLocation x = new MapLocation(20, 20, map);
            }
            catch(Exception)
            {
                Console.WriteLine("That map location is not on the map!");
            }

            Console.ReadLine();
        }
    }
}
