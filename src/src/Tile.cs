﻿using System;
using System.Collections.Generic;

namespace src
{
    public class Tile
    {
        private Typ typ;
        private Direction dir;
        private int rotation;
        private Player owner;
        private int fill;
        private List<Tile> neighbours;

        public enum Typ {
            stop = 1,
            turn = 3,
            straight = 5,
            tee = 7,
            cross = 15,
            empty = 254,
            start = 255,
        }

        public enum Direction
        {
            north,
            east,
            south,
            west,
            none,
        }

        public Tile(Player owner, int typ)
        {
            this.owner = owner;
            this.typ = (Typ)typ;
            this.neighbours = new List<Tile>();
        }

        public void SetNeighbour(Tile t, Direction d)
            {
            this.setNeighbour(t, (int)d);
            }
        private void setNeighbour(Tile t, int d)
        {
            this.neighbours.Insert(d, t);
        }

        public void SetTyp(Typ typ)
        {
            this.typ = typ;
        }
        public Typ GetTyp()
            {
                return this.typ;
            }


        public Tile GetNeighbour(Direction d)
        {
            return this.getNeighbour((int)d);
        }
        private Tile getNeighbour(int d)
            {
                return this.neighbours[(int)d];
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
                        this.rotation += 3;
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

            // keep amount within multiples of 100!!
            public void FillOne(int amount)
            {
                if (!this.IsFull())
                {
                    this.fill += amount;
                }
                if (this.fill > 100)
                {
                    this.fill = 100;
                }
            }

            public int GetFill()
            {
                return fill;
            }

            public bool IsFull()
            {
                return this.fill == 100;
            }


        public bool CheckMatchesWith(Tile t, int dirToTile)
        {
            int ourMatchBits = this.getMatchBits();

            // check if we have an opening in this direction, if not it matches
            if ((ourMatchBits & 1 << dirToTile) == 0)
            {
                return false;
            }

            // get the bits of the other tile
            int otherTileMatchBits = t.getMatchBits();

            int oppositeDir = 1 << ((dirToTile + 2) % 4);

            // get the bit we are comparing against
            //int compareBit = 1 << (oppositeDir);
            if ((otherTileMatchBits & oppositeDir) == 0)
            {
                return false;
            }
            return true;
        }

        // this logic is faulty. Should probably return three states; 0 = spill (endgame), 1 = flow can continue, 2 = flow is blocked
        public bool CheckOverflow()
        {
            int matchBits = this.getMatchBits();
            for (int i = 0; i < 4; i++) {
                if ((matchBits & i) == 0)
                {
                    continue;
                }
                Tile t = this.getNeighbour(i);
                if (t.GetTyp() == Typ.empty)
                {
                    return true;
                }
                if (this.CheckMatchesWith(this, i))
                {
                    return true;
                }
            }
            return false;
        }

        public int getMatchBits()
        {
            if (this.rotation == 0 || (int)this.typ == 0x0f) 
            {
                return (int)this.typ;
            }
            int l = (int)this.typ;
            l <<= this.rotation;
            if (l < 0x10)
            {
                return l;
            }
            int r = l;
            r &= 0x0f;
            int mask = 0x10 << (this.rotation - 1);
            l &= mask - 1;
            l >>= 4;
            r |= l;
            return r;
        }
    }
}
