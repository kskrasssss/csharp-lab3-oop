using System.Collections.Generic;

namespace Lab3Task4
{
    // Інтерфейс: тільки "що" треба вміти, без реалізації
    public interface IUniversity
    {
        void AddTeacher(Teacher teacher);
        List<Teacher> SearchByDepartment(string departmentName);
    }
}