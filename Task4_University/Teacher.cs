using System;

namespace Lab3Task4
{
    // Абстрактний клас: не можна створити об'єкт напряму
    public abstract class Teacher
    {
        // Поля
        protected string fullName;
        protected string department;
        protected int experience; // стаж у роках

        public Teacher(string fullName, string department, int experience)
        {
            this.fullName = fullName;
            this.department = department;
            this.experience = experience;
        }

        // Звичайні (не абстрактні) методи
        public string GetDepartment()
        {
            return department;
        }

        public string GetFullName()
        {
            return fullName;
        }

        // Абстрактні методи (без реалізації, її напишуть нащадки)
        public abstract double CalculateSalary();
        public abstract string GetInfo();
    }
}