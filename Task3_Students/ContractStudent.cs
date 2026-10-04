using System;

namespace Lab3Task3
{
    public class ContractStudent : Student
    {
        private bool isPaid; // чи сплачено контракт

        public ContractStudent() : base()
        {
            isPaid = false;
        }

        public ContractStudent(string fullName, int course, int minGrade, bool isPaid)
            : base(fullName, course, minGrade)
        {
            this.isPaid = isPaid;
        }

        public ContractStudent(string fullName) : base(fullName)
        {
            isPaid = false;
        }

        ~ContractStudent()
        {
            Console.WriteLine("Лабораторна робота виконана студентом 2 курсу Прізвище Ім'я По батькові");
        }

        public void SetPaid(bool paid)
        {
            isPaid = paid;
        }

        // override = перевизначення методу базового класу
        public override void MoveToNextCourse()
        {
            if (minGrade >= 3 && isPaid)
                course++;
        }

        public override int GetScholarship()
        {
            return 0; // контрактник завжди 0
        }

        public override string Info()
        {
            return base.Info() + ", контракт сплачено: " + (isPaid ? "так" : "ні");
        }
    }
}