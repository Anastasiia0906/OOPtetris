using System;
using System.Windows;
using System.Windows.Threading;

namespace курсова1
{
    public partial class GameWindow : Window
    {
        private DispatcherTimer gameTimer;
        private GameField gameField;
        private Tetromino currentPiece;
        private Tetromino nextPiece;

        public GameWindow()
        {
            InitializeComponent();
            gameField = new GameField(10, 20, 25);
            currentPiece = TetrominoFactory.CreateRandom();
            nextPiece = TetrominoFactory.CreateRandom();
            gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromMilliseconds(500);
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        private void GameLoop(object? sender, EventArgs e)
        {
            currentPiece.Move(0, 1);
            if (gameField.IsCollision(currentPiece))
            {
                currentPiece.Move(0, -1);
                gameField.LockTetromino(currentPiece);
                gameField.ClearFullLines();
                currentPiece = nextPiece;
                nextPiece = TetrominoFactory.CreateRandom();

                if (gameField.IsCollision(currentPiece))
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over!");
                    Close();
                }
            }

            gameField.Draw(GameCanvas);
            currentPiece.Draw(GameCanvas, gameField.CellSize);
        }
    }
}
