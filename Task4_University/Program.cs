using System;
using System.Collections.Generic;

namespace Lab3Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Змінна типу інтерфейсу, об'єкт класу-сервісу
            UniversityImpl university = new UniversityImpl();

            // Додаємо різних викладачів
            university.AddTeacher(new Professor("Петренко П.П.", "Інформатика", 20, 60));
            university.AddTeacher(new AssociateProfessor("Коваль О.І.", "Математика", 10, 12));
            university.AddTeacher(new Professor("Шевченко Т.Г.", "Математика", 15, 30));
            university.AddTeacher(new AssociateProfessor("Бондар М.В.", "Інформатика", 5, 8));

            Console.WriteLine("=== Усі викладачі ===");
            university.ShowAll();

            // Пошук за кафедрою (виклик методу інтерфейсу)
            Console.Write("\nВведіть назву кафедри для пошуку: ");
            string dep = Console.ReadLine();

            List<Teacher> found = university.SearchByDepartment(dep);

            Console.WriteLine("\n=== Результат пошуку ===");
            if (found.Count == 0)
            {
                Console.WriteLine("Нікого не знайдено.");
            }
            else
            {
                foreach (Teacher t in found)
                {
                    Console.WriteLine(t.GetInfo());
                }
            }
        }
    }
}