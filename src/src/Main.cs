using System;
namespace src
{
    public class MainClass
    {
        public static void Main(string []args)
        {
            Game g = new Game(3);
            Tile t = g.getNextTile();
            Console.WriteLine(g.getNextTile().typ);
            for (int i = 0; i < 4; i++)
            {
                t.Rotate(true);
                Console.WriteLine(t.GetRotation());
            }
            for (int i = 0; i < 4; i++)
            {
                t.Rotate(false);
                Console.WriteLine(t.GetRotation());
            }
        }
    }
}
