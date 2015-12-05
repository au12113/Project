using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Player
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }
        private int _hp;
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        private int _status;
        public int Status
        { 
            get { return _status; }
            set { _status = value; }
        }
        protected int _locx;
        public int LocX
        {
            get { return _locx; }
            set { _locx = value; }
        }
        private int _locy;
        public int LocY
        {
            get { return _locy; }
            set { _locy = value; }
        }
        //METHOD
        public Player(string name)
        {
            _name = name;
            HP = 3;
            Status = 0;
        }
        public int pLocX()
        {

            return LocX;
        }
    }
}
