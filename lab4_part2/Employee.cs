using System;

namespace lab4_part2_Serov
{
    public class Employee
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal BaseSalary { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsActive { get; set; }

        private const decimal MIN_SALARY = 15000.0m;
        private static int _totalEmployees = 0;
        public static readonly string CompanyName = "TechCorp";

        public Employee()
        {
            Id = ++_totalEmployees;
            FirstName = "Unknown";
            LastName = "Unknown";
            Department = "Undefined";
            BaseSalary = MIN_SALARY;
            ExperienceYears = 0;
            IsActive = true;
        }

        public Employee(int id, string firstName, string lastName, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            BaseSalary = MIN_SALARY;
            ExperienceYears = 0;
            IsActive = true;
            _totalEmployees++;
        }

        public Employee(Employee other)
        {
            Id = other.Id + 1000;
            FirstName = other.FirstName;
            LastName = other.LastName;
            Department = other.Department;
            BaseSalary = other.BaseSalary;
            ExperienceYears = other.ExperienceYears;
            IsActive = other.IsActive;
            _totalEmployees++;
        }

        public decimal CalculateTotalSalary()
        {
            decimal experienceBonus = BaseSalary * 0.02m * ExperienceYears;
            return BaseSalary + experienceBonus;
        }

        public string GetFullInfo()
        {
            return $"{Id}: {FirstName} {LastName}, {Department}, ЗП: {BaseSalary:C}";
        }

        public string GetFullInfo(bool includeSalary)
        {
            if (includeSalary)
                return $"{Id}: {FirstName} {LastName}, {Department}, ЗП: {CalculateTotalSalary():C}";
            else
                return $"{Id}: {FirstName} {LastName}, {Department}";
        }

        public void Promote(string newDepartment, decimal salaryIncrease)
        {
            Department = newDepartment;
            BaseSalary += salaryIncrease;
            ExperienceYears++;
        }

        public string GetWorkStatus()
        {
            return IsActive ? "Активен" : "Неактивен";
        }

        public static decimal GetAverageSalary(Employee[] employees)
        {
            if (employees.Length == 0) return 0;
            decimal total = 0;
            foreach (var emp in employees)
                total += emp.CalculateTotalSalary();
            return total / employees.Length;
        }

        ~Employee()
        {
            _totalEmployees--;
        }
    }
}