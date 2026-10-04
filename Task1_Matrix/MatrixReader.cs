using System;
using System.Collections.Generic;
using System.IO;

namespace Lab3Task1
{
    // Клас зчитує матрицю з файлу
    public class MatrixReader : IDisposable
    {
        private StreamReader reader;

        public MatrixReader(string path)
        {
            reader = new StreamReader(path);
        }

        public int[,] Read()
        {
            // Спочатку читаємо рядки у список, бо не знаємо їх кількість
            List<string> lines = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Trim() != "")
                    lines.Add(line);
            }

            int rows = lines.Count;
            int cols = lines[0].Split(' ').Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(parts[j]);
                }
            }

            return matrix;
        }

        public void Dispose()
        {
            reader.Dispose();
        }
    }
}