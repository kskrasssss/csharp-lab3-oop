using System;
using System.Collections.Generic;

namespace Lab3Task4
{
    // Клас-сервіс: реалізує інтерфейс і керує списком викладачів
    public class UniversityImpl : IUniversity
    {
        // Колекція захована всередині класу (інкапсуляція)
        private List<Teacher> teachers = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public List<Teacher> SearchByDepartment(string departmentName)
        {
            List<Teacher> result = new List<Teacher>();
            foreach (Teacher t in teachers)
            {
                if (t.GetDepartment() == departmentName)
                    result.Add(t);
            }
            return result;
        }

        // Вивід усієї бази
        public void ShowAll()
        {
            foreach (Teacher t in teachers)
            {
                Console.WriteLine(t.GetInfo());
            }
        }
    }
}