using System;

namespace src
{
    public class Tile
    {
        private Typ typ;
        private Direction dir;
        private int rotation;
        private Player owner;
        private int fill;
        private int entrance;

        public enum Typ {
            empty,
            straight,
            turn,
            tee,
            cross,
            stop,
            start
        }

        public enum Direction
        {
            north,
            east,
            south,
            west,
            max,
        }

        public Tile(Player owner, int typ)
        {
            this.owner = owner;
            this.typ = (Typ)typ;
        }

        public Typ GetTyp()
        {
            return this.typ;
        }

        public int GetRotation()
        {
            return this.rotation;
        }

        public Player GetOwner()
        {
            return this.owner;
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

        public void StartFill(Direction dir)
        {
            this.dir = dir;
        }

        public Direction GetDirection()
        {
            return this.dir;
        }

        //
        public void FillOne(int amount)
        {
            this.fill += amount;
        }

        public int GetFill()
        {
            return fill;
        }
    }
}
