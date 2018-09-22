using System;
namespace src
{
    public class MainClass
    {
        public static void Main(string []args)
        {
            Game g = new Game(3, 10, 10, 60);
            Tile t = g.GetNextTile();
            Console.WriteLine(t.GetTyp());
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

            Tile t2 = new Tile(g.GetCurrentPlayer(), (int)Tile.Typ.straight);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(t2.getMatchBits());
                t2.Rotate(true);
            }
        }
    }
}
