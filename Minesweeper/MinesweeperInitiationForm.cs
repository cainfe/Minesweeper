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
    public partial class MinesweeperInitiationForm : Form
    {
        public MinesweeperInitiationForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            new Thread(() => new MinesweeperForm((int)(nudNumBombs.Value), (int)(nudGridWidth.Value), (int)(nudGridHeight.Value)).ShowDialog()).Start();
            //MinesweeperForm minesweeperForm = new MinesweeperForm((int)(nudNumBombs.Value), (int)(nudGridWidth.Value), (int)(nudGridHeight.Value));

            

            //minesweeperForm.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
