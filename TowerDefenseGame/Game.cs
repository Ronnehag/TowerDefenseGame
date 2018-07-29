using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenseGame.Invaders;

namespace TowerDefenseGame
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            try
            {
                Path path = new Path(
                    new[] {
                    new MapLocation(0,2,map),
                    new MapLocation(1,2,map),
                    new MapLocation(2,2,map),
                    new MapLocation(3,2,map),
                    new MapLocation(4,2,map),
                    new MapLocation(5,2,map),
                    new MapLocation(6,2,map),
                    new MapLocation(7,2,map),
                    });


                IInvader[] invaders =
                {
                    new BasicInvader(path),
                    new ResurrectingInvader(path),
                    new StrongInvader(path),
                    new FastInvader(path),
                    new ShieldedInvader(path)
                };

                Tower[] towers = {
                    new PowerfulTower(new MapLocation(1, 3, map)),
                    new SniperTower(new MapLocation(3, 3, map)),
                    new LongRangeTower(new MapLocation(5, 3,map))
                };

                Level levelOne = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = levelOne.Play();

                Console.WriteLine("Player " + (playerWon ? "won!" : "lost."));


            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefensException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception " + ex);
            }

            Console.ReadLine();
        }
    }
}
