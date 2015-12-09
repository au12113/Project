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
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;

        }

        public void Notify(Model m)
        {
            UpdateBoard(((THModel)m).GetBoard());
        }

        private void UpdateTile(PictureBox pb,Tile b)
        {
            pb.Visible = ((Tile)b).Tvisible();
            pb.Enabled = ((Tile)b).Tvisible();
        }
        private void UpdateBoard(Tile[,] board)
        {
            UpdateTile(pictureBox2, board[0, 0]);
            UpdateTile(pictureBox3, board[1, 0]);
            UpdateTile(pictureBox4, board[2, 0]);
            UpdateTile(pictureBox6, board[2, 1]);
            Run.Enabled = ((THModel)model).btnRun_visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.ActionPerformed(0);
        }
        
    }
}
