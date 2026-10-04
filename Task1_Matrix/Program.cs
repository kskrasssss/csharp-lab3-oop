using System;

namespace Lab3Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string path = "grades.txt";
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
            // Console.WriteLine("Студентів з незадовільними оцінками: " + badStudents);
            // Console.WriteLine("Студентів-відмінників: " + excellentStudents);
        }
    }
}