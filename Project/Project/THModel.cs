using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class THModel : Model
    {
        protected Tile[,] board = new Tile[3,3];
        protected Player player = new Player(0, 0);
        public bool btnRun_visible = true;
        public THModel () 
        {
            board[0, 0] = new Tile(0);
            board[1, 0] = new Tile(0, 1);
            board[2, 0] = new Tile();
            board[2, 1] = new Tile();
            NotifyAll();
        }

        public Tile[,] GetBoard()
        {
            return board;
        }

        public bool RunVisible()
        {
            return btnRun_visible;
        }

        public void Dice()                          //ActionPerform : 0
        {
            int tmpX = player.posX + 1;
            for (int i = 0; i < 3; i++)
            {
                int tmpY = board[0, player.posY].nextY[i];
                if (tmpY < 99)
                {
                    board[tmpX, tmpY].setVisible(true);
                }
            }
            btnRun_visible = false;
            NotifyAll();
        }
    }
}
