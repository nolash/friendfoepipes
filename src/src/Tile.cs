using System;

namespace src
{
    public class Tile
    {
        public Typ typ;
        int rotation;
        Player owner;
        int fill;

        public enum Typ {
            straight,
            turn,
            tee,
            cross,
            max
        }

        public Tile(Player owner, int typ)
        {
            this.owner = owner;
            this.typ = (Typ)typ;
        }

        public int GetRotation()
        {
            return this.rotation;
        }

        // dir true = cw
        public void Rotate(bool dir)
        {
            {
                if (dir)
                {
                    this.rotation++;
                }
                else
                {
                    this.rotation+=3;
                }
                this.rotation %= 4;
            }
        }
        public void Fill(int amount)
        {

        }
    }
}
