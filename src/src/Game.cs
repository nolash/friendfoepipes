using System;
using System.Collections.Generic;

namespace src
{

    public class Game
    {
        public Player currentPlayer;
        List<Player> players;

        public Game(int numPlayers, int waterStep, int waterRate, int TimeLimit)
        {
            for (int i = 0; i < numPlayers; i++)
            {
                players = new List<Player>();
                this.players.Add(new Player());
            }
            this.currentPlayer = this.players[0];
        }

        public Tile getNextTile()
            {
                Random rnd = new Random();
                int max = (int)Tile.Typ.max;
                Tile t = new Tile(currentPlayer, rnd.Next(0, max));
                return t;
           }
    }
}
