using System.Windows.Controls;
using Tetris;

namespace курсова1
{
    public class GameField
    {
        public int Width { get; }
        public int Height { get; }
        public int CellSize { get; }

        public GameField(int width, int height, int cellSize)
        {
            Width = width;
            Height = height;
            CellSize = cellSize;
        }

        public bool IsCollision(Tetromino piece)
        {
            // Тимчасово завжди повертаємо false, щоб не було помилок
            return false;
        }

        public void LockTetromino(Tetromino piece)
        {
            // Логіку зафіксувати фігури поки пропустимо
        }

        public void ClearFullLines()
        {
            // Логіку очищення ліній поки пропустимо
        }

        public void Draw(Canvas canvas)
        {
            // Для початку очистимо канвас
            canvas.Children.Clear();
            // Тут буде логіка малювання поля
        }
    }
}
