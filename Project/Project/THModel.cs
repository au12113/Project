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

        protected Player[] player = new Player[2];

        public THModel () 
        {
            board = new Tile[3, 3];
            //var range = Enumerable.Range(0, 3);
            /* foreach (int i in range)
             {
                 foreach (int j in range)
                 {
                     board[i, j] = new Tile(0, 0, 0);
                 }
             }*/
            board[0, 0] = new Tile(0, 0, 0);
            board[1, 0] = new Tile(1, 0, 0);
            board[1, 1] = new Tile(1, 1, 0);
            board[0, 0].addNextTile(board[1, 0]);
            board[0, 0].addNextTile(board[1, 1]);
            board[0, 0].PosPlayer = 1;
            NotifyAll();
        }

        public Tile[,] GetBoard()
        {
            return board;
        }
        
        public void PerformUp()
        {
            board[1, 0].PosPlayer = 1;
            NotifyAll();
        }
    }
}
