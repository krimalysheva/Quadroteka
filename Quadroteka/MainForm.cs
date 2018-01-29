using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormsUtils;
using ProgramLogicUtilits.Quadroteka;

namespace Quadroteka
{
    public partial class MainForm : Form
    {
        private static int CELLS_COUNT = 5;

        private Game game = new Game();

        private Dictionary<int, Brush> colorsMap = new Dictionary<int, Brush>() {
            { 0, Brushes.Red },
            { 1, Brushes.Blue },
            { 2, Brushes.Green },
            { 3, Brushes.Yellow },
            { 4, Brushes.Purple },
        };

        private Dictionary<Keys, Action> controlMap;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeGameSettings();

            InitializeGameSettings();
            InitializeGameUI();
        }

        private void InitializeGameSettings()
        {
            controlMap = new Dictionary<Keys, Action>() {
                // Перемещение квадрата
                { Keys.Up, game.MoveUp },
                { Keys.Down, game.MoveDown },
                { Keys.Left, game.MoveLeft },
                { Keys.Right, game.MoveRight },

                // Поворот
                { Keys.X, game.RotateClockwise },
                { Keys.Z, game.RotateAntiClockwise },
            };
        }

        private void InitializeGameUI()
        {
            int cellSize = this.Width / CELLS_COUNT;

            this.Width = cellSize * CELLS_COUNT + 40;
            this.Height = gameFieldDataGridView.Location.Y + cellSize * CELLS_COUNT + 45;

            // настраиваем DataGridView
            gameFieldDataGridView.RowTemplate.Height = cellSize;
            gameFieldDataGridView.Font = new Font("Comic Sans MS", 12);
            DataGridViewUtils.InitGridForArr(gameFieldDataGridView, cellSize, true, false, false, false, false);

            gameFieldDataGridView.Width = cellSize * CELLS_COUNT + 3;
            gameFieldDataGridView.Height = cellSize * CELLS_COUNT + 3;
            gameFieldDataGridView.RowCount = CELLS_COUNT;
            gameFieldDataGridView.ColumnCount = CELLS_COUNT;
        }

        private void UpdateView()
        {
            switch (game.State) {
                case GameState.PLAYING:
                    gameStateLabel.Text = "Игра идет ";
                    gameStateLabel.ForeColor = Color.Black;
                    break;
                case GameState.WIN:
                    gameStateLabel.Text = "Победа";
                    gameStateLabel.ForeColor = Color.DarkGreen;
                    break;
            }

            movesCountLabel.Text = game.MovesCount.ToString();
            turnsCountLabel.Text = (game.TurnsCount-1).ToString();

            rowsCollectedLabel.Text = game.RowsCollected.ToString();

            gameFieldDataGridView.Invalidate();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            game.NewGame(CELLS_COUNT);
            UpdateView();
        }

        private void gameFieldDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (game.State != GameState.PLAYING)
            {
                e.CellStyle.BackColor = Color.White;
                e.PaintBackground(e.CellBounds, false);

                e.Handled = true;
                return;
            }


            Cell cell = game[e.RowIndex, e.ColumnIndex];

            // отрисовка фона

            if (game.InnerSquare.IsPointInside(e.RowIndex, e.ColumnIndex))
            {
                e.CellStyle.BackColor = Color.Black;
                
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }

            e.PaintBackground(e.CellBounds, false);

            int x = e.CellBounds.Location.X + 5;
            int y = e.CellBounds.Location.Y + 10;
            int radius = 50;

            e.Graphics.FillEllipse(colorsMap[cell.Value], e.CellBounds.X + 5, e.CellBounds.Y + 5, e.CellBounds.Width - 10, e.CellBounds.Height - 10);

            // e.Graphics.DrawString(content, gameFieldDataGridView.Font, brush, e.CellBounds, cellStringFormat);

            // сообщаем, что ячейка полностью отрисована
            e.Handled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Если нажали клавишу перемещения и находимся в режиме активной игры
            if (game.State == GameState.PLAYING && controlMap.ContainsKey(keyData))
            {
                controlMap[keyData]();
                UpdateView();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
