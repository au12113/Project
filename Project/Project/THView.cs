using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class THView : Form,View
    {
        Model model;
        Controller controller;
        public THView()
        {
            InitializeComponent();
            model = new THModel();
            model.AttachObserver(this);
            controller = new THController();
            controller.AddModel(model);
        }

        public void Notify(Model m)
        {
            UpdateBoard(((THModel)m).GetBoard());
        }

        private void UpdatePlayer(Label l, int i)
        {
            if (i != 0)
            {
                l.Text = Convert.ToString(i);
            }
            else
            {
                l.Text = "";
            }
            switch (i)
            {
                case 0:
                    l.BackColor = Color.Gray;
                    break;
                case 2:
                    l.BackColor = Color.DarkGray;
                    break;
                case 4:
                    l.BackColor = Color.Orange;
                    break;
                case 8:
                    l.BackColor = Color.Red;
                    break;
                default:
                    l.BackColor = Color.Green;
                    break;
            }
        }
        private void UpdateBoard(Tile[,] board)
        {
            
        }


    }
}
