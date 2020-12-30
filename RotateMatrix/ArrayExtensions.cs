using System;

#pragma warning disable CA1814
#pragma warning disable S2368

namespace RotateMatrix
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Rotates the image clockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            int row = matrix.GetLength(0);
            for (int i = 0; i < row; i++)
            {
                for (int j = i; j < row; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, row - 1 - j];
                    matrix[i, row - 1 - j] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            int row = matrix.GetLength(0);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, row - 1 - j];
                    matrix[i, row - 1 - j] = temp;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = i; j < row; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            for (int i = 0; i < 2; i++)
            {
                Rotate90DegreesClockwise(matrix);
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            for (int i = 0; i < 2; i++)
            {
                Rotate90DegreesCounterClockwise(matrix);
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            for (int i = 0; i < 3; i++)
            {
                Rotate90DegreesClockwise(matrix);
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            for (int i = 0; i < 3; i++)
            {
                Rotate90DegreesCounterClockwise(matrix);
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            for (int i = 0; i < 4; i++)
            {
                Rotate90DegreesClockwise(matrix);
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException($"Throw when source matrix is null. {nameof(matrix)}");
            }

            for (int i = 0; i < 4; i++)
            {
                Rotate90DegreesCounterClockwise(matrix);
            }
        }
    }
}
