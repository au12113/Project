using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Tile
    {
        //Not sure : private Location(x,y)
        private int _btC;           //BoardTileColumn
        public int btColumn
        { get { return _btC; } }

        private int _btR;           //BoardTileRow
        public int btRow
        { get { return _btR; } }

        private int _item;          //Item & Trap
        public int Item
        {
            get { return _item; }
            set
            {
                if (value >= 0 && value < 3)
                    _item = value;
            }
        }
        private int _posPlayer;
        public int PosPlayer
        {
            get { return _posPlayer; }
            set { _posPlayer = value; }
        }
        private List<Tile> nextTile = new List<Tile>();
        //Method
        public Tile(int c, int r, int item)
        {
            _btC = c;
            _btR = r;
            _item = item;
        }
        public void addNextTile(Tile nt)
        {
            nextTile.Add(nt);
        }
    }
}
