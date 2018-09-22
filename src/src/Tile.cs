using System;

namespace foo
{
    public class Tile
    {
        char type;
        char rotation;
        Player owner;
        char fill;

        public Tile(Player owner)
        {
            this.owner = owner;
        }

        public rotate(int dir) {
            {
                if (dir)
                {
                    this.rotation++;
                }
                else
                {
                    this.rotation--;
                }
                this.rotation %= 4;
            }
    }
}
