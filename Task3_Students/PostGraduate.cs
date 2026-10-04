using System;

namespace Lab3Task3
{
    public class PostGraduate : Student
    {
        private string supervisor; // керівник роботи

        public PostGraduate() : base()
        {
            supervisor = "Невідомо";
        }

        public PostGraduate(string fullName, int course, int minGrade, string supervisor)
            : base(fullName, course, minGrade)
        {
            this.supervisor = supervisor;
        }

        public PostGraduate(string fullName) : base(fullName)
        {
            supervisor = "Невідомо";
        }

        ~PostGraduate()
        {
            Console.WriteLine("Лабораторна робота виконана студентом 2 курсу Краснікова Катерина Євгенівна");
        }

        public void SetSupervisor(string newSupervisor)
        {
            supervisor = newSupervisor;
        }

        public override void MoveToNextCourse()
        {
            if (minGrade >= 4)
                course++;
        }

        public override int GetScholarship()
        {
            return 5000; // аспірант завжди 5000
        }

        public override string Info()
        {
            return base.Info() + ", керівник: " + supervisor;
        }
    }
}