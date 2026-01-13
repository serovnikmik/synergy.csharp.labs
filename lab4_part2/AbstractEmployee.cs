using System;

namespace lab4_part2_Serov
{
    public abstract class AbstractEmployee
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal BaseSalary { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsActive { get; set; }

        private static int _totalEmployees = 0;

        protected AbstractEmployee(int id, string firstName, string lastName, string department, decimal baseSalary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            BaseSalary = baseSalary;
            ExperienceYears = 0;
            IsActive = true;
            _totalEmployees++;
        }

        public abstract string GetWorkDescription();

        public virtual decimal CalculateBonus()
        {
            return 0;
        }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static int GetTotalEmployees()
        {
            return _totalEmployees;
        }

        ~AbstractEmployee()
        {
            _totalEmployees--;
        }
    }
}