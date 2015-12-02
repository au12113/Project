using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class THModel : Model
    {
        protected Tile[,] board;
        protected Random rand;

        public THModel () 
        {
            board[0, 0] = new Tile(0, 0, 0);
            board[0, 1] = new Tile(0, 1, 0);
            NotifyAll();
        }

        public Tile[,] GetBoard()
        {
            return board;
        }

        
    }
}
