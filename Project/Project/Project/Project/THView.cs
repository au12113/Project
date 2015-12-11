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
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
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
            UpdateTile(pictureBox5, board[3, 0]);
            UpdateTile(pictureBox6, board[2, 1]);
            UpdateTile(pictureBox7, board[3, 1]);
            Run.Enabled = ((THModel)model).btnRun_enable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.ActionPerformed(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = pictureBox3.Location;
            pictureBox3.Enabled = false;
            pictureBox3.Visible = false;
            Run.Enabled = true;
            ((THModel)model).tmpX = 1;
            ((THModel)model).tmpY = 0;
            controller.ActionPerformed(1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = pictureBox4.Location;
            pictureBox4.Enabled = false;
            pictureBox4.Visible = false;
            pictureBox6.Enabled = false;
            pictureBox6.Visible = false;
            Run.Enabled = true;
            ((THModel)model).tmpX = 2;
            ((THModel)model).tmpY = 0;
            controller.ActionPerformed(1);
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = pictureBox6.Location;
            pictureBox4.Enabled = false;
            pictureBox4.Visible = false;
            pictureBox6.Enabled = false;
            pictureBox6.Visible = false;
            Run.Enabled = true;
            ((THModel)model).tmpX = 2;
            ((THModel)model).tmpY = 1;
            controller.ActionPerformed(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = pictureBox5.Location;
            pictureBox5.Enabled = false;
            pictureBox5.Visible = false;
            pictureBox7.Enabled = false;
            pictureBox7.Visible = false;
            Run.Enabled = true;
            ((THModel)model).tmpX = 3;
            ((THModel)model).tmpY = 0;
            controller.ActionPerformed(1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = pictureBox7.Location;
            pictureBox5.Enabled = false;
            pictureBox5.Visible = false;
            pictureBox7.Enabled = false;
            pictureBox7.Visible = false;
            Run.Enabled = true;
            ((THModel)model).tmpX = 3;
            ((THModel)model).tmpY = 1;
            controller.ActionPerformed(1);
        }
    }
}
