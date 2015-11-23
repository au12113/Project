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
        protected int[,] board;
        protected Random rand;

        public THModel () : this(4)
        {
            // default board size is 4 
        }

        public int[,] GetBoard()
        {
            return board;
        }

        public THModel(int size)
        {
            boardSize = size;
            board = new int[boardSize, boardSize];
            var range = Enumerable.Range(0, boardSize);
            foreach (int i in range)
            {
                foreach (int j in range)
                {
                    board[i, j] = 0;
                }
            }
            NotifyAll();
        }
    }
}
