using System;

namespace Lab3Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "grades.txt";
            int students = 5; // кількість студентів (рядків)
            int exams = 4;    // кількість іспитів (стовпців)

            // 1. Генерація матриці випадкових оцінок від 2 до 5
            Random random = new Random();
            int[,] matrix = new int[students, exams];
            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < exams; j++)
                {
                    matrix[i, j] = random.Next(2, 6); // 6 не входить
                }
            }

            // 2. Запис у файл (using автоматично закриє файл)
            using (MatrixWriter writer = new MatrixWriter(path))
            {
                writer.Write(matrix);
            }

            // 3. Зчитування з файлу
            int[,] readMatrix;
            using (MatrixReader reader = new MatrixReader(path))
            {
                readMatrix = reader.Read();
            }

            // Виводимо матрицю на екран
            Console.WriteLine("Оцінки студентів:");
            for (int i = 0; i < readMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < readMatrix.GetLength(1); j++)
                {
                    Console.Write(readMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 4. Підрахунок
            int badStudents = 0;       // мають хоч одну двійку
            int excellentStudents = 0; // всі оцінки "відмінно" (5)

            for (int i = 0; i < readMatrix.GetLength(0); i++)
            {
                bool hasBad = false;
                bool allExcellent = true;

                for (int j = 0; j < readMatrix.GetLength(1); j++)
                {
                    if (readMatrix[i, j] < 3)
                        hasBad = true;
                    if (readMatrix[i, j] != 5)
                        allExcellent = false;
                }

                if (hasBad) badStudents++;
                if (allExcellent) excellentStudents++;
            }

            Console.WriteLine("Студентів з незадовільними оцінками: " + badStudents);
            Console.WriteLine("Студентів-відмінників: " + excellentStudents);
        }
    }
}

