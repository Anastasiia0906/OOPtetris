using System;
using System.Windows.Media;

namespace курсова1
{
    public static class TetrominoFactory
    {
        private static readonly Random random = new();

        // Класичні фігури тетрісу
        private static readonly (int[,], Brush)[] Shapes = new (int[,], Brush)[]
        {
            // I
            (new int[,] {
                {1,1,1,1}
            }, Brushes.Cyan),

            // O
            (new int[,] {
                {1,1},
                {1,1}
            }, Brushes.Yellow),

            // T
            (new int[,] {
                {0,1,0},
                {1,1,1}
            }, Brushes.Purple),

            // S
            (new int[,] {
                {0,1,1},
                {1,1,0}
            }, Brushes.Green),

            // Z
            (new int[,] {
                {1,1,0},
                {0,1,1}
            }, Brushes.Red),

            // J
            (new int[,] {
                {1,0,0},
                {1,1,1}
            }, Brushes.Blue),

            // L
            (new int[,] {
                {0,0,1},
                {1,1,1}
            }, Brushes.Orange),
        };

        public static Tetromino CreateRandom()
        {
            int index = random.Next(Shapes.Length);
            var (shape, color) = Shapes[index];
            return new Tetromino(shape, color);
        }
    }
}
