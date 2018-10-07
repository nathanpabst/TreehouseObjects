using System;

namespace TreehouseObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower();
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);
            Console.WriteLine(point.DistanceTo(5, 5)); 

            Console.Read();
        }
    }
}
