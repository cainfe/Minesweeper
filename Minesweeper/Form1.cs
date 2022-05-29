using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Image mineSweeperPreview = (Image)(Properties.Resources.msScreenshot);
            mineSweeperPreview = new Bitmap(mineSweeperPreview, new Size(btnPreviewMinesweeper.Width, btnPreviewMinesweeper.Height));
            btnPreviewMinesweeper.Image = mineSweeperPreview;
        }

        private void launchGame (string game)
        {
            if (game == "minesweeper")
                new Thread(() => new MinesweeperInitiationForm().ShowDialog()).Start();
        }// End lanchGame

        private void btnPlayMinesweeper_Click(object sender, EventArgs e)
        {
            launchGame("minesweeper");
        }

        private void btnPreviewMinesweeper_Click(object sender, EventArgs e)
        {
            launchGame("minesweeper");
        }
    }
}
