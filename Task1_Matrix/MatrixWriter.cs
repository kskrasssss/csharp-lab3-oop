using System;
using System.IO;

namespace Lab3Task1
{
    // Клас відповідає ТІЛЬКИ за запис матриці у файл
    public class MatrixWriter : IDisposable
    {
        private StreamWriter writer;

        public MatrixWriter(string path)
        {
            writer = new StreamWriter(path);
        }

        public void Write(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    writer.Write(matrix[i, j]);
                    if (j < cols - 1)
                        writer.Write(" "); // розділяємо числа пробілом
                }
                writer.WriteLine(); // новий рядок = новий студент
            }
        }

        // Звільнення ресурсів (закриття файлу)
        public void Dispose()
        {
            writer.Dispose();
        }
    }
}