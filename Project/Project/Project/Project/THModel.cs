using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class THModel : Model
    {
        protected Tile[,] board = new Tile[4,3];
        protected Player player = new Player(0, 0);
        public int tmpX;
        public int tmpY;
        public bool btnRun_visible = true;

        public THModel () 
        {
            board[0, 0] = new Tile(0);
            board[1, 0] = new Tile(0, 1);
            board[2, 0] = new Tile(0);
            board[2, 1] = new Tile(1);
            board[3, 0] = new Tile();
            board[3, 1] = new Tile();
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
            tmpX = player.posX + 1;
            for (int i = 0; i < 3; i++)
            {
                tmpY = board[player.posX, player.posY].nextY[i];
                if (tmpY != 99)
                {
                    board[tmpX, tmpY].setVisible(true);
                }
            }
            btnRun_visible = false;
            NotifyAll();
        }
        public void Walk()
        {
            player.setPPos(tmpX,tmpY);
            board[tmpX, tmpY].setVisible(false);
        }
        
    }
}
