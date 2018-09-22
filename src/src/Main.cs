using System;
using System.Collections.Generic;

namespace src
{
    public class MainClass
    {
        public static void Main(string[] args)
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

            List<int> tests = new List<int>();
            tests.Insert(0, 1);
            tests.Insert(1, 3);
            tests.Insert(2, 5);
            tests.Insert(3, 7);
            tests.Insert(4, 15);

            List<int> corrects = new List<int>(20);

            // stop
            corrects.Add(1);
            corrects.Add(2);
            corrects.Add(4);
            corrects.Add(8);

            // turn
            corrects.Add(3);
            corrects.Add(6);
            corrects.Add(12);
            corrects.Add(9);

            // straight
            corrects.Add(5);
            corrects.Add(10);
            corrects.Add(5);
            corrects.Add(10);

            // tee
            corrects.Add(7);
            corrects.Add(14);
            corrects.Add(13);
            corrects.Add(11);

            // cross
            corrects.Add(15);
            corrects.Add(15);
            corrects.Add(15);
            corrects.Add(15);

            for (int j = 0; j < 5; j++)
            {
                Tile t2 = new Tile(g.GetCurrentPlayer(), tests[j]);
                Console.WriteLine("---");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(String.Format("{0:00} ---> ", t2.getMatchBits()));
                    Console.WriteLine(String.Format("{0:00} <--- ", corrects[(j * 4) + i]));
                    t2.Rotate(true);
                }
               
            }
        }
    }
}
