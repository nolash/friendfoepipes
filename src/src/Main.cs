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

            Tile pivotManual = new Tile(g.GetCurrentPlayer(), (int)Tile.Typ.stop);
            Tile compareManual = new Tile(g.GetCurrentPlayer(), (int)Tile.Typ.stop);
            compareManual.Rotate(true);
            compareManual.Rotate(true);
            pivotManual.CheckMatchesWith(compareManual, 0);

            List<bool> matchCorrects = new List<bool>();

            // pivot typ stop 0x01

            // compare typ stop 0x01

            // compare rotate 0

            matchCorrects.Add(false);
                matchCorrects.Add(false);
                matchCorrects.Add(false);
            matchCorrects.Add(false);

                // rotate 1
            matchCorrects.Add(false);
                 matchCorrects.Add(false);
                 matchCorrects.Add(false);
                 matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // compare typ turn 0x03

            // compare rotate 0

            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);


            // compare typ straight

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);


            // compare typ tee

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);


            // compare typ cross

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);


            // pivot type turn

            // compare typ stop

            // compare rotate 0

            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // compare typ turn

            // compare rotate 0

            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);


            // compare typ straight

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // compare typ tee

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // compare typ cross

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(true);
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);


            // pivot type straight

            // compare typ stop

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // compare typ turn

            // compare rotate 0

            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);


            // compare typ straight

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // compare typ tee

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(false);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // compare typ cross

            // compare rotate 0

            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 1
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 2
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            // rotate 3
            matchCorrects.Add(true);
            matchCorrects.Add(false);
            matchCorrects.Add(true);
            matchCorrects.Add(false);

            for (int i = 0; i < 3; i++) // check all types for pivot
            {
                Tile tPivot = new Tile(g.GetCurrentPlayer(), tests[i]);

                for (int j = 0; j < 5; j++) // check all types for compare
                {
                    Tile tCompare = new Tile(g.GetCurrentPlayer(), tests[j]);
                    for (int k = 0; k < 4; k++) // check all rotations
                    {
                        for (int l = 0; l < 4; l++) { // check all directions
                            bool doesMatch = tPivot.CheckMatchesWith(tCompare, l);
                            Console.WriteLine(String.Format("{0:00} {1:00} {2:00} {3:00} {4} - {5}", i, j, k, l, doesMatch, matchCorrects[(i*16*5)+(j*16)+(k*4)+l]));
                        }
                        tCompare.Rotate(true);
                    }
                }
            }

        }
    }
}
