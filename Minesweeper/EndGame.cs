using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class EndGame : Form
    {
        bool win;

        public EndGame()
        {
            InitializeComponent();
        }

        public EndGame(bool win)
        {
            this.win = win;
            InitializeComponent();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            if (win)
                label1.Text = "You won!";
            else
                label1.Text = "You lost.";

            int newX = (this.Width / 2 - label1.Width / 2) - 16;
            int newY = this.Height / 2 - label1.Height / 2 - 39;

            label1.Left = newX;
            label1.Top = newY;
            //label1.Location = new Point(newX, newY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
