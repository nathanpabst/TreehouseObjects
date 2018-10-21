using System;

namespace TreehouseObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8,5);
            //handle exception here with try/catch since this is the first file run in the program
            try
            {
                Path path = new Path(
                    //passing the array into the constructor
                    new[] {
                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map),
                        new MapLocation(5,2, map),
                        new MapLocation(6,2, map),
                        new MapLocation(7,2, map),
                        }
                );

                Invader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(3,3,map)),
                    new Tower(new MapLocation(3,4,map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine($"{playerWon} ? won : lost");
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("unhandled TreehouseDefense exception.");
            }
            //by adding variable ex to the Exception message, we get more info about the type of exception that is occurring
            catch (Exception ex)
            {
                Console.WriteLine($"unhandled exception. {ex}");
            }

            Console.Read();
        }


    }

}
