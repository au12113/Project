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

        private void UpdateTile(PictureBox pb,int isHere)
        {
            if(isHere == 1)
                pictureBox1.Location = pb.Location;
        }
        private void UpdateBoard(Tile[,] board)
        {
            UpdateTile(pictureBox2, board[1, 0].PosPlayer);
            UpdateTile(pictureBox3, board[1, 1].PosPlayer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.ActionPerformed(0);
        }
    }
}
