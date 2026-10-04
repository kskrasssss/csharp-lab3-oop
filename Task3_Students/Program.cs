using System;

namespace Lab3Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Введення даних для звичайного студента
            Console.WriteLine("--- Студент ---");
            Console.Write("ПІБ: ");
            string name1 = Console.ReadLine();
            Console.Write("Курс: ");
            int course1 = int.Parse(Console.ReadLine());
            Console.Write("Мін. оцінка: ");
            int grade1 = int.Parse(Console.ReadLine());
            Student student = new Student(name1, course1, grade1);

            // Введення даних для контрактника
            Console.WriteLine("--- Студент-контрактник ---");
            Console.Write("ПІБ: ");
            string name2 = Console.ReadLine();
            Console.Write("Курс: ");
            int course2 = int.Parse(Console.ReadLine());
            Console.Write("Мін. оцінка: ");
            int grade2 = int.Parse(Console.ReadLine());
            Console.Write("Контракт сплачено? (true/false): ");
            bool paid = bool.Parse(Console.ReadLine());
            ContractStudent contract = new ContractStudent(name2, course2, grade2, paid);

            // Введення даних для аспіранта
            Console.WriteLine("--- Аспірант ---");
            Console.Write("ПІБ: ");
            string name3 = Console.ReadLine();
            Console.Write("Курс: ");
            int course3 = int.Parse(Console.ReadLine());
            Console.Write("Мін. оцінка: ");
            int grade3 = int.Parse(Console.ReadLine());
            Console.Write("Керівник роботи: ");
            string supervisor = Console.ReadLine();
            PostGraduate postGraduate = new PostGraduate(name3, course3, grade3, supervisor);

            // Масив базового типу: тут працює динамічний поліморфізм
            Student[] students = { student, contract, postGraduate };

            Console.WriteLine("\n=== До оновлення ===");
            foreach (Student s in students)
            {
                s.MoveToNextCourse(); // викличеться потрібна версія методу
                Console.WriteLine(s.Info());
            }

            // Оновлення інформації про об'єкти
            student.Update(1, 5);
            contract.Update(2, 4);
            contract.SetPaid(true);
            postGraduate.Update(3, 5);
            postGraduate.SetSupervisor("Іваненко І.І.");

            Console.WriteLine("\n=== Після оновлення ===");
            foreach (Student s in students)
            {
                Console.WriteLine(s.Info());
            }
        }
    }
}