using System;

namespace Lab3Task4
{
    public class AssociateProfessor : Teacher
    {
        private int lecturesPerWeek; // кількість лекцій на тиждень

        public AssociateProfessor(string fullName, string department, int experience, int lecturesPerWeek)
            : base(fullName, department, experience)
        {
            this.lecturesPerWeek = lecturesPerWeek;
        }

        public override double CalculateSalary()
        {
            return 20000 + experience * 300 + lecturesPerWeek * 400;
        }

        public override string GetInfo()
        {
            return "Доцент: " + fullName + ", кафедра: " + department +
                   ", стаж: " + experience + ", лекцій на тиждень: " + lecturesPerWeek +
                   ", зарплата: " + CalculateSalary() + " грн";
        }

        // Власні методи, характерні тільки для AssociateProfessor
        public void AddLectures(int count)
        {
            lecturesPerWeek += count;
        }

        public bool IsOverloaded()
        {
            return lecturesPerWeek > 10;
        }
    }
}