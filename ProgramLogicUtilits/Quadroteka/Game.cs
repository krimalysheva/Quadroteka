using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogicUtilits.Quadroteka
{
    public class Game
    {
        private const int INNER_SQUARE_SIZE = 3;

        private Random rnd = new Random();

        private GameState state = GameState.NOT_STARTED;
        private Cell[,] field = null;
        private int fieldSize = 0;

        private Square innerSquare;

        private int rowsCollected = 0;
        private int turnsCount = 0;
        private int movesCount = 0;

        public Game() {

        }

        public void NewGame(int fieldSize, int level = 2)
        {
            this.fieldSize = fieldSize;

            innerSquare = new Square(INNER_SQUARE_SIZE);
            rowsCollected = 0;
            movesCount = 0;
            turnsCount = 0;

            field = new Cell[fieldSize, fieldSize];

            int fillCols = (fieldSize + 1) / level;
            int currentRowValue = level - 1;

            for (int c = 0; c < fieldSize; c++)
            {
                for (int r = 0; r < fieldSize; r++)
                {
                    field[r, c] = new Cell { Value = currentRowValue };
                }

                fillCols--;

                if (fillCols == 0)
                {
                    fillCols = (fieldSize + 1) / level;
                    currentRowValue--;
                }

            }

            state = GameState.PLAYING;

            ShuffleField();
            UpdateGameState();
        }

        public void ShuffleField()
        {
            for (int i = 0; i < 1; i++)
            {
                RotateFieldFragment(
                    new Square(
                        INNER_SQUARE_SIZE, 
                        rnd.Next(0, fieldSize - INNER_SQUARE_SIZE + 1), 
                        rnd.Next(0, fieldSize - INNER_SQUARE_SIZE + 1)
                    ),
                    Rotation.Clockwise
                );
            }

            this.UpdateGameState();
        }

        private Cell[,] CloneField()
        {
            Cell[,] tempField = new Cell[fieldSize, fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    tempField[i, j] = new Cell { Value = field[i, j].Value };
                }
            }

            return tempField;
        }

        private void RotateFieldFragment(Square fragment, Rotation rotationType)
        {
            Cell[,] tempField = CloneField();

            int r1 = fragment.Y;
            int c1 = fragment.X;

            int r2 = fragment.Y + fragment.Size - 1;
            int c2 = fragment.X + fragment.Size - 1;

            for (int r = r1; r <= r2; r++)
            {
                for (int c = c1; c <= c2; c++)
                {
                    // Начинаем координаты с нуля
                    int r0 = r - r1;
                    int c0 = c - c1;

                    // Вычисляем позицию, в которую переходит текущая ячейка
                    int rr, cr;

                    if (rotationType == Rotation.Clockwise)
                    {
                        rr = c0;
                        cr = fragment.Size - r0 - 1;
                    }
                    else {
                        rr = fragment.Size - c0 - 1;
                        cr = r0;
                    }

                    // Выполняем преобразование
                    tempField[rr + r1, cr + c1] = this.field[r, c];
                }
            }

            this.field = tempField;

            turnsCount++;
            UpdateGameState();
        }
        
        public void RotateClockwise()
        {
            RotateFieldFragment(innerSquare, Rotation.Clockwise);
        }

        public void RotateAntiClockwise()
        {
            RotateFieldFragment(innerSquare, Rotation.AntiClockwise);
        }

        public void MoveRight()
        {
            if (InnerSquare.X < fieldSize - InnerSquare.Size)
            {
                InnerSquare.X++;
                movesCount++;
            }
        }
        
        public void MoveLeft()
        {
            if (InnerSquare.X > 0)
            {
                InnerSquare.X--;
                movesCount++;
            }
        }

        public void MoveUp()
        {
            if (InnerSquare.Y > 0)
            {
                InnerSquare.Y--;
                movesCount++;
            }
        }

        public void MoveDown()
        {
            if (InnerSquare.Y < fieldSize - InnerSquare.Size)
            {
                InnerSquare.Y++;
                movesCount++;
            }
        }

        private void UpdateGameState()
        {
            if (state != GameState.PLAYING)
                return;

            rowsCollected = 0;

            // Считаем, сколько столбцов собрали
            for (int c = 0; c < fieldSize; c++)
            {
                bool isCollected = true;

                for (int r = 1; r < fieldSize; r++)
                {
                    if (this.field[r, c].Value != this.field[r-1, c].Value)
                    {
                        isCollected = false;
                        break;
                    }
                }

                if (isCollected)
                {
                    rowsCollected++;
                }
            }

            if (rowsCollected == fieldSize)
            {
                state = GameState.WIN;
            }
        }

        public int FieldSize
        {
            get
            {
                return fieldSize;
            }
        }

        public GameState State
        {
            get
            {
                return state;
            }
        }

        public Square InnerSquare {
            get {
                return innerSquare;
            }
        }

        public Cell this[int row, int col]
        {
            get
            {
                return field[row, col];
            }
        }

        // Игровая статистика
        public int MovesCount
        {
            get
            {
                return movesCount;
            }
        }

        public int TurnsCount
        {
            get
            {
                return turnsCount;
            }
        }

        public int RowsCollected
        {
            get
            {
                return rowsCollected;
            }
        }
    }
}
