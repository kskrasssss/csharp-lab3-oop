using System;

namespace Lab3Task3
{
    public class Student
    {
        // Поля (protected, щоб похідні класи мали до них доступ)
        protected string fullName;
        protected int course;
        protected int minGrade;

        // Конструктор за замовчуванням
        public Student()
        {
            fullName = "Невідомо";
            course = 1;
            minGrade = 0;
        }

        // Конструктор для ініціалізації
        public Student(string fullName, int course, int minGrade)
        {
            this.fullName = fullName;
            this.course = course;
            this.minGrade = minGrade;
        }

        // Конструктор перезавантаження (тільки ПІБ, решта за замовчуванням)
        public Student(string fullName)
        {
            this.fullName = fullName;
            course = 1;
            minGrade = 0;
        }

        // Деструктор
        ~Student()
        {
            Console.WriteLine("Лабораторна робота виконана студентом 2 курсу Краснікова Катерина Євгенівна");
        }

        // virtual дозволяє перевизначати метод у похідних класах
        public virtual void MoveToNextCourse()
        {
            if (minGrade >= 3)
                course++;
        }

        public virtual int GetScholarship()
        {
            if (minGrade == 4) return 2000;
            if (minGrade == 5) return 3000;
            return 0; // оцінка 3 і нижче
        }

        public virtual string Info()
        {
            return "ПІБ: " + fullName + ", курс: " + course +
                   ", мін. оцінка: " + minGrade +
                   ", стипендія: " + GetScholarship() + " грн";
        }

        // Метод оновлення даних
        public void Update(int newCourse, int newMinGrade)
        {
            course = newCourse;
            minGrade = newMinGrade;
        }
    }
}