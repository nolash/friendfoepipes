using System;
using System.Collections.Generic;

namespace src
{

    public class Game
    {
        private uint waterLevel;
        private uint waterRate;
        private uint waterSpeed;
        private uint tilesGiven;
        public Player currentPlayer;
        List<Player> players;

        public Game(int numPlayers, uint waterRate, uint waterSpeed, uint TimeLimitSeconds)
        {
            for (int i = 0; i < numPlayers; i++)
            {
                players = new List<Player>();
                this.players.Add(new Player());
            }
            this.currentPlayer = this.players[0];
            this.waterLevel = 0;
            this.waterRate = waterRate;
            this.waterSpeed = waterSpeed;
        }

        public Tile GetNextTile()
            {
                Random rnd = new Random();
                Tile t = new Tile(currentPlayer, (int)Tile.Typ.start);
                this.tilesGiven++;
                return t;
           }

        public void Fill()
        {
            this.waterLevel += this.waterRate;
        }
    }
}
