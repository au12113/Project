using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Tile
    {
        public bool visible = false;
        public int[] nextY = new int[3];
        // Method
        public Tile(int y0 = 99, int y1 = 99, int y2 = 99)
        {
            nextY[0] = y0;
            nextY[1] = y1;
            nextY[2] = y2;
        }
        public bool Tvisible()
        {
            return visible;
        }
        public void setVisible(bool b)
        {
            visible = b;
        }
    }
}
