using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class THController : Controller
    {
        public override void ActionPerformed(int action)
        {
            foreach (THModel m in mList)
            {
                switch (action)
                {
                    case LEFT:
                        m.PerformLeft();
                        break;
                    case RIGHT:
                        m.PerformRight();
                        break;
                    case UP:
                        m.PerformUp();
                        break;
                    case DOWN:
                        m.PerformDown();
                        break;
                }

            }
        }
    }
}
