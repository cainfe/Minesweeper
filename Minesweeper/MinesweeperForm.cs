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
    public partial class MinesweeperForm : Form
    {
        const int padding = 50;
        int btnSize = 30;
        int numBombs, remainingTiles;
        int gridWidth;
        int gridHeight;
        Button[,] btnGrid;
        bool[,] bombGrid;
        bool[,] flaggedGrid;
        bool[,] questionedGrid;
        bool[,] enabledGrid;
        Button closeBtn;

        public MinesweeperForm()
        {
            InitializeComponent();
        }

        public MinesweeperForm(int numBombs, int gridWidth, int gridHeight)
        {
            InitializeComponent();
            this.numBombs = numBombs;
            this.remainingTiles = gridWidth * gridHeight - numBombs;
            this.gridWidth = gridWidth;
            this.gridHeight = gridHeight;

            btnGrid = new Button[gridHeight, gridWidth];
            bombGrid = new bool[gridHeight, gridWidth];
            flaggedGrid = new bool[gridHeight, gridWidth];
            questionedGrid = new bool[gridHeight, gridWidth];
            enabledGrid = new bool[gridHeight, gridWidth];
            // Initialize all values of 'bombGrid' and 'flaggedGrid' to false.
            for (int i = 0; i < gridHeight; i++) {
                for (int j = 0; j < gridWidth; j++) {
                    bombGrid[i, j] = false;
                    flaggedGrid[i, j] = false;
                    questionedGrid[i, j] = false;
                    enabledGrid[i, j] = true;
                }
            }

            this.Height = (gridHeight * btnSize) + (2 * padding) + 39;
            this.Width = (gridWidth * btnSize) + (2 * padding) + 16;

            closeBtn = new Button();
            closeBtn.Text = "Give up";
            closeBtn.Height = 24;
            closeBtn.Width = 100;
            closeBtn.Top = this.Height - 76;
            closeBtn.Left = this.Width / 2 - closeBtn.Width / 2 - 16;
            closeBtn.Click += closeBtnClickEvent;
            this.Controls.Add(closeBtn);

            constructField();
        }// End Constructor

        private void closeBtnClickEvent(object sender, EventArgs e)
        {
            endGame();
        }// End closeBtnClickEvent

        private void constructField()
        {
            new Thread(() => placeBombs()).Start();
            createGrid();
        }// End constructField

        // The event ran when one of the buttons on the grid is clicked.
        private void clickEvent(object sender, MouseEventArgs a)
        {
            Button tmpButton = (Button)sender;
            string[] temp = tmpButton.Tag.ToString().Split(' ');
            int row = Convert.ToInt32(temp[0]);
            int column = Convert.ToInt32(temp[1]);

            // If user right clicks and button is enabled, alternat through flagged, questioned, or empty. 
            // Else call 'sweepGrid' from current location.
            if (enabledGrid[row, column]) {
                if (a.Button == MouseButtons.Right) {
                    if (!flaggedGrid[row, column] && !questionedGrid[row, column])
                        flagBtn(row, column);
                    else if (flaggedGrid[row, column]) {
                        unflagBtn(row, column);
                        questionBtn(row, column);
                    }
                    else if (questionedGrid[row, column])
                        unquestionBtn(row, column);
                }
                else if (a.Button == MouseButtons.Left) {
                    if (flaggedGrid[row, column]) {
                        // if button is flagged, do nothing.
                    }
                    else if (bombGrid[row, column] == false) {
                        sweepGrid(row, column);
                        if (remainingTiles == 0)
                            endGame();
                    }
                    else {
                        explodeBtn(row, column);
                        endGame();
                    }
                }
            }
        }// End clickEvent

        private void disableBtn(int row, int column)
        {
            enabledGrid[row, column] = false;
        }// End disableBtn

        private void sweepGrid(int row, int column)
        {
            int adjacent = adjacentBombs(row, column);

            Image defaultBtn = (Image)(Properties.Resources.msButtonPressed);
            defaultBtn = new Bitmap(defaultBtn, new Size(btnSize, btnSize));
            btnGrid[row, column].Image = defaultBtn;
            disableBtn(row, column);
            remainingTiles--;

            if (adjacent == 0)
            {
                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = column - 1; j <= column + 1; j++)
                    {
                        if (i >= 0 && i < gridHeight && j >= 0 && j < gridWidth && enabledGrid[i, j])
                            sweepGrid(i, j);
                    }
                }
            }
            else
            {
                if (adjacent == 1)
                    btnGrid[row, column].ForeColor = Color.Blue;
                else if (adjacent == 2)
                    btnGrid[row, column].ForeColor = Color.Green;
                else if (adjacent == 3)
                    btnGrid[row, column].ForeColor = Color.Red;
                else if (adjacent == 4)
                    btnGrid[row, column].ForeColor = Color.Purple;
                else if (adjacent == 5)
                    btnGrid[row, column].ForeColor = Color.Maroon;
                else if (adjacent == 6)
                    btnGrid[row, column].ForeColor = Color.Turquoise;
                else if (adjacent == 7)
                    btnGrid[row, column].ForeColor = Color.Black;
                else if (adjacent == 8)
                    btnGrid[row, column].ForeColor = Color.Gray;

                btnGrid[row, column].FlatAppearance.BorderColor = Color.Black;
                btnGrid[row, column].Font = new Font(Button.DefaultFont.FontFamily, 12);
                btnGrid[row, column].Text = "" + adjacent;
            }
        } // End sweepGrid

        private int adjacentBombs(int row, int column)
        {
            int total = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = column - 1; j <= column + 1; j++)
                {
                    if (i >= 0 && i < gridHeight && j >= 0 && j < gridWidth)
                        if (bombGrid[i, j])
                            total++;
                }
            }

            return total;
        }// End adjacentBombs

        private void flagBtn(int row, int column) 
        {
            Image flaggedBtn = (Image)(Properties.Resources.msFlaggedBtn);
            flaggedBtn = new Bitmap(flaggedBtn, new Size(btnSize, btnSize));
            btnGrid[row, column].Image = flaggedBtn;

            flaggedGrid[row, column] = true;
        }// End flagBtn

        private void unflagBtn(int row, int column)
        {
            Image msButton = (Image)(Properties.Resources.msButton);
            msButton = new Bitmap(msButton, new Size(btnSize, btnSize));
            btnGrid[row, column].Image = msButton;

            flaggedGrid[row, column] = false;
        } // End unflagBtn

        private void questionBtn(int row, int column)
        {
            Image questionBtn = (Image)(Properties.Resources.msQuestionedBtn);
            questionBtn = new Bitmap(questionBtn, new Size(btnSize, btnSize));
            btnGrid[row, column].Image = questionBtn;

            questionedGrid[row, column] = true;
        }// End flagBtn

        private void unquestionBtn(int row, int column)
        {
            Image msButton = (Image)(Properties.Resources.msButton);
            msButton = new Bitmap(msButton, new Size(btnSize, btnSize));
            btnGrid[row, column].Image = msButton;

            questionedGrid[row, column] = false;
        } // End unflagBtn

        private void revealBombs()
        {
            for (int i = 0; i < gridHeight; i++) {
                for (int j = 0; j < gridWidth; j++) {
                    disableBtn(i, j);
                    if (bombGrid[i, j] && !flaggedGrid[i, j]) {
                        explodeBtn(i, j);
                    }
                }
            }
        }// End revealBombs

        private void explodeBtn(int row, int column)
        {
            Image bombBtn = (Image)(Properties.Resources.msBomb);
            bombBtn = new Bitmap(bombBtn, new Size(btnSize, btnSize));
            btnGrid[row, column].Image = bombBtn;

            //bombGrid[row, column] = false;
        }// End explodeBtn

        private void endGame()
        {
            revealBombs();
            if (remainingTiles == 0)
                endGameForm(true);
            else
                endGameForm(false);
        }// End endGame

        private void endGameForm(bool win)
        {
            EndGame endForm = new EndGame(win);
            endForm.ShowDialog();
            this.Close();
        }// End endGameForm

        // Creates a grid of buttons with 'numBoxes'.
        private void createGrid()
        {

            // create a grid of buttons for the fields selections.
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    Button temp = new Button();
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.FlatAppearance.BorderSize = 1;
                    temp.TabStop = false;
                    // Position the button
                    temp.Left = padding + j * btnSize;
                    temp.Top = padding + i * btnSize;
                    // Size the button
                    temp.Width = btnSize;
                    temp.Height = btnSize;
                    // Assign events to button
                    temp.MouseDown += clickEvent;
                    // Sets buttons image
                    Image defaultBtn = (Image)(Properties.Resources.msButton);
                    defaultBtn = new Bitmap(defaultBtn, new Size(btnSize, btnSize));
                    temp.Image = defaultBtn;

                    temp.Tag = i + " " + j;
                    btnGrid[i, j] = temp;
                    this.Controls.Add(temp);
                }
            }
        }// End createGrid

        // Places the bombs in a random order throught the grid.
        private void placeBombs()
        {
            Random rand = new Random(); // To generate a random number.
            int row, column;
            int bombsPlaced = 0;
            while (bombsPlaced < numBombs) {
                column = rand.Next(0, gridWidth);
                row = rand.Next(0, gridHeight);
                if (bombGrid[row,column] == false) {
                    bombGrid[row, column] = true;
                    bombsPlaced++;
                }
            }
        }// End placeBombs
    }
}
