using System;

namespace Lab3Task4
{
    public class Professor : Teacher
    {
        private int publicationsCount; // кількість публікацій

        public Professor(string fullName, string department, int experience, int publicationsCount)
            : base(fullName, department, experience)
        {
            this.publicationsCount = publicationsCount;
        }

        // Реалізація абстрактних методів
        public override double CalculateSalary()
        {
            return 30000 + experience * 500 + publicationsCount * 200;
        }

        public override string GetInfo()
        {
            return "Професор: " + fullName + ", кафедра: " + department +
                   ", стаж: " + experience + ", публікацій: " + publicationsCount +
                   ", зарплата: " + CalculateSalary() + " грн";
        }

        // Власні методи, характерні тільки для Professor
        public void PublishArticle()
        {
            publicationsCount++;
        }

        public bool IsLeadingScientist()
        {
            return publicationsCount > 50;
        }
    }
}