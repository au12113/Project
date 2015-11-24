using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class THModel : Model
    {
        protected int boardSize; // default is 4
        protected Tile[,] board;
        protected Random rand;

        public THModel () 
        {
            board[0, 0] = new Tile(0,0,0);
            NotifyAll();
        }

        public int[,] GetBoard()
        {
            return board;
        }

        
    }
}
